using System.Collections;

namespace Homework3_LiudvynskyiV.S.Models;

// Homework #4
public class ProductComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is null || y is null || x is not Product || y is not Product)
        {// де відбувається перехоплення цього винятку?
            throw new ArgumentException("Incorrect value!");
        }
        var firstProduct = x as Product;
        var secondProduct = y as Product;
        // Якщо різниця в копійках, буде не добре.
        return (int)(firstProduct.Price - secondProduct.Price);
    }
}
