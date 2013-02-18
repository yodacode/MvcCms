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











