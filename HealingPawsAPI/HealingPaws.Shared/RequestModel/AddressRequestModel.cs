﻿
namespace HealingPaws.Shared.RequestModel;
public class AddressRequestModel: BaseRequestModel
{
    public string Line1 { get; set; }
    public string Line2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string Zip { get; set; }
}
