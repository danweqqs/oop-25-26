using System;

interface IPriceable
{
    void SetPrice(double price);
}

interface IDiscountable
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}

interface IColorable
{
    void SetColor(byte color);
}

interface ISizable
{
    void SetSize(byte size);
}

class Book : IPriceable, IDiscountable
{
    public void SetPrice(double price)
    {
        /*...*/
    }

    public void ApplyDiscount(String discount)
    {
        /*...*/
    }

    public void ApplyPromocode(String promocode)
    {
        /*...*/
    }
}

class Outerwear : IPriceable, IDiscountable, IColorable, ISizable
{
    public void SetPrice(double price)
    {
        /*...*/
    }

    public void ApplyDiscount(String discount)
    {
        /*...*/
    }

    public void ApplyPromocode(String promocode)
    {
        /*...*/
    }

    public void SetColor(byte color)
    {
        /*...*/
    }

    public void SetSize(byte size)
    {
        /*...*/
    }
}