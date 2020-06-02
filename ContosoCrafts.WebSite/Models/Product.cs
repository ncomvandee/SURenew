using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContosoCrafts.WebSite.Models
{
    // The Products class accesses and changes the item data in the View Posts page. 
    public class Product
    {
        // Gets/Sets the post id in the view posts page. 
        public string Id { get; set;}
       
        // Gets/Sets the post author email in the view posts page. 
        public string Maker { get; set; }

        // Gets/Sets the Image in the view posts page
        [JsonPropertyName("img")]
        public string Image { get; set; }

        // Gets/Sets the title of the card in the view posts page. 
        public string Title { get; set; }

        // Gets/Sets the post date in the view posts page. 
        public string Date { get; set; }

        // Gets/Sets the item description in the view posts page. 
        public string Description { get; set; }

        // Overrides the toString method
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
        
    }
}
