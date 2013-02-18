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

##Class ChangePassword

-	string OldPassword
-	string NewPassword
-	string ConfirmPassword





