using System.ComponentModel.DataAnnotations;

namespace Tangy_WebServer.Data.DTOs;

public class CategoryDTO
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Please enter your name")]
    public string? Name { get; set; }
}