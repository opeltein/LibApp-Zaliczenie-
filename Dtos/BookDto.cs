using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LibApp.Models;

namespace LibApp.Dtos
{
@@ -12,5 +13,11 @@ public class BookDto
        [Required]
    [StringLength(255)]
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public Genre Genre { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int NumberInStock { get; set; }
    public int NumberAvailable { get; set; }
}
}
