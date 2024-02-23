using System.Text.Json.Serialization;

namespace ilcs_test_programmer.model;

public class Product {
    [JsonPropertyName("hs_code_format")]
    public string HsCodeFormat { get; set; }
    
    [JsonPropertyName("detailId")]
    public string UraianId { get; set; }
    
    [JsonPropertyName("sub_header")]
    public string SubHeader { get; set; }
    
}