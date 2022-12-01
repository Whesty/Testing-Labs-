using System;
using IntegerCalculator;
using Xunit;

namespace Tests;

public class UnitTest
{
    //Плюс
    [Fact]
    public void Add_1and2()//+
    {
        var calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Assert.Equal(3, result);
    }
    //Минус

    [Fact]
    public void Subtract_1and2()//-
    {
        var calculator = new Calculator();
        var result = calculator.Subtract(1, 2);
        Assert.Equal(-1, result);
    }
    //Умножение

    [Fact]
    public void Multiply_2and2()//*
    {
        var calculator = new Calculator();
        var result = calculator.Multiply(1, 2);
        Assert.Equal(2, result);
    }
    //Остеток

    [Fact]
    public void Modulus_1and2()//%
    {
        var calculator = new Calculator();
        var result = calculator.Modulus(1, 2);
        Assert.Equal(1, result);
    }
    //Степень

    [Fact]
    public void Power_10and2()//^
    {
        var calculator = new Calculator();
        var result = calculator.Power(10, 2);
        Assert.Equal(100, result);
    }
    //Факториал

    [Fact]
    public void Factorial_5()//!
    {
        var calculator = new Calculator();
        var result = calculator.Factorial(5);
        Assert.Equal(120, result);
    }
    
    
    [Fact]
    public void Factorial_0()//0!
    {
        var calculator = new Calculator();
        var result = calculator.Factorial(0);
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Factorial_1()//1!
    {
        var calculator = new Calculator();
        var result = calculator.Factorial(1);
        Assert.Equal(1, result);
    }


    //Проверка ошибок

    [Fact]
    public void Divide_1and0Exception()//Exeption /
    {
        var calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(1, 0));
    }


    [Fact]
    public void Factorial_minus5Exception()//Exception !
    {
        var calculator = new Calculator();
        Assert.Throws<ArgumentException>(() => calculator.Factorial(-5));
    }
}