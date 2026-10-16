using System.ComponentModel.DataAnnotations;

namespace Core_Mvc_Advanced.Models
{
    public class InsertClss
    {
        public int stId { get; set; }
        public string? stName { get; set; }
        public int dId { get; set; }
        public string? dName { get; set; }
        public List<CheckBoxListHelper>? MyFavoriteQual { get; set; }
        public string[]? selectedQual { get; set; }
        [Required(ErrorMessage = "***")]
        public string? sname { get; set; }
        [Range(20,50 ,ErrorMessage="Enter a valid age")]
        public int sage { set; get; }
        public string? Gender { get; set; }
        public string? Qual { get;set; }
        public string? sphoto { get; set; }
    }

    public class Stclass
    {
        public int stId { get; set; }
        public string? stName { set; get; }

    }

    public class Dclass
    {
        public int dId { get; set; }
        public string? dName { set; get; }
    }

    public class CheckBoxListHelper
    {
        public string? Value { get; set; }
        public string? Text { get;set; }
        public bool IsChecked { get; set; }
    }


}
