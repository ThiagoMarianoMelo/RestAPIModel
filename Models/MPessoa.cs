using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace RestAPIModel.Models.MPessoa{

    [BindNever]
    public class MPessoa{
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
    public int ID {get; set;}

    [BindRequired]
    public String? nome { get; set; }

    [BindRequired]
    public int idade { get; set; }

    [BindRequired]
    public float altura { get; set; }
}

}

