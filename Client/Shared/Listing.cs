
namespace SynthSearcherUI.Client.Shared;
public class Listing
{
    public int? __id {get;set;}
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal? Price { get; set; }
    public decimal? Shipping { get; set; }
    public string Currency { get; set; }
    public string Site { get; set; }
    public string Url { get; set; }
    public DateTime? Posted { get; set; }
    public List<string>? Tags { get; set; }
    public string uid { get; set; }
    public bool? inStock { get; set; }

}