 
Post post1 = new Post();
post1.Coments = "0";
post1.like = 10;
System.Console.WriteLine(post1.about());
Console.WriteLine("Your command : ");
Console.WriteLine("(Commands : like; comment )");
string command = Console.ReadLine();
Console.WriteLine(post1.setting(command));



class Post{
    public string Coments;
    public int like;
    public string text;

    public string about()
    {
        return $"Comments {this.Coments} Likes {this.like}";
    }
    public string setting(string command)
    {
        
        if( command == "like")like++;
       else if (command == "comment"){
        Coments = Console.ReadLine();
        return $"Your coment : {Coments}";
       }
       return $"Comments {this.Coments} Likes {this.like}";
    }
}
