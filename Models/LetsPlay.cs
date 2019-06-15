using Microsoft.AspNetCore.Http;

namespace Play.Models
{
    public class LetsPlay
    {
        public string Firstname {get;set;}
        public string Lastname {get;set;}
        public string Phone {get;set;}
        public string Email {get;set;}
        public IFormFile Document {get;set;}
    }
}