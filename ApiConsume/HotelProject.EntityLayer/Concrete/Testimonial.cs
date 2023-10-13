﻿namespace HotelProject.EntityLayer.Concrete;

public class Testimonial
{
    public int TestimonialId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
}
