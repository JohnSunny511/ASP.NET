namespace CoreAPIAngular.Models
{
    public class Userclss
    {
        public int uid { set; get; }
        public string? name { set; get; }
        public int age { set; get; }
        public string? addr { set; get; }
        public string? email { set; get; }
         //for DB
        public string? photo { set; get; }
        public string? uname { set; get; }
        public string? password { set; get; }
    }

    public class UserCreateDTO
    {
        public string? name { set; get; }
        public int age { set; get; }
        public string? addr { set; get; }
        public string? email { set; get; }
        //get uploaded image fro save
        public IFormFile? path { set; get; }
        public  string? uname { set; get; }
        public string? password { set; get; }
    }

    public class UserLoginDTO
    {
        public string? uname { set; get; }
        public string? password { set; get; }
    }
}
