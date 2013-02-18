PROJET .NET POUR LE WEB
========================================================================

Benjamin de Vaublanc 
Dorian Boussac
Wiston Cherry 
GROUPE EB1


Les Models
------------------------------------------------------------------------
### Post attributs
-	int  PostId 
-	int  TagId
-	int AuthorId
-	string Title
-	DateTime Date
-	string Content
-	Tag Tag
-	Author Author
-	bool Online

### Page attributs
-	int PageId
-	int AuthorId
-	string Title
-	DateTime Date
-	string Content
-	Author Author
-	bool Online

### Tag attributs
-	Int TagId
-	String Name
-	virtual ICollection<Post>  Posts

### Author attributs
-	int AuthorId
-	string Name
-	List<Post> Posts

### Message

-	int MessageId
-	string Name
-	string Site
-	string Title
-	string content
-	bool statement

### AccountModels

####Class ChangePassword

-	string OldPassword
-	string NewPassword
-	string ConfirmPassword

####Class LogOnModel

-	string UserName
-	string Password
-	bool RememberMe

####Class RegisterModel

-	string UserName
-	string Email
-	string Password
-	string ConfirmPAssword

####CmsEntities : DbContext
-	DbSet<Key> Keys
-	DbSet<Post> Posts
-	DbSet<Page> Pages
-	DbSet<Message> Messages

####SampleData
Pour pouvoir remplir la base de donnée avec des données fictives, lorsque la base de donnée se réinitialise, Cf la method Application_Start()

````
protected void Application_Start()
{
    System.Data.Entity.Database.SetInitializer(new MvcCms.Models.SampleData());
}
````

Les Controllers 
------------------------------------------------------------------------

Pour chaque entité nous avons décidé de créer deux Controller

Un controller détenant les actions publiques à tous les visiteurs et un autre destiné aux actions privées pour les utilisateurs et administrateur,  par convention ce dernier comportera la mention Manager


EX : Model Post

PostController 
(contenant les action publique du site)

PostManagerController  
(contenant les action réservé aux membres et administrateur) 


Certaine classe et actions seront précédé de la mention ````[Authorize]```` afin d’être accessible seulement par des membres du site. D’autres requiert des droits Administrateur, ces dernières seront précédé. 
par un ````[Authorize(Roles = « Administrator »)]````.


Rappel : les rôles on été géré à l’aide de l’interface ASP.NET Configuration.
Pour accéder aux actions de l’administrateur. Il faut créer un compte admin avec un rôle Administrator

### PostController
-	Index return view()
Permet de lister tous les posts
-	Abstract(int limit) return view()
Permet de récupérer les derniers posts par ordre anté-chronologique en fonction de la limit paramétré 
-	Navigation (int tag, string title) return view()
Permet de récupérer les posts ou tag = tagId, le deuxième paramètre title nous servira plus tard pour le formatage de la route.
-	Details(int id) return view(post)
Permet d’accéder au detail d’un post
