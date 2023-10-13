﻿namespace HotelProject.EntityLayer.Concrete;

public class Service
{
    public int ServiceId { get; set; }
    public string ServiceRoom { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
