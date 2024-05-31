﻿
using MediatR;

namespace Core_Console.ContextIntersection1;

public class GetFilmByIdQueryBase
{
    public override bool Equals(object? obj)
    {
        Console.WriteLine("");
        Test();
        return base.Equals(obj);
    }

    private void Test()
    {
        new MyClass().Test();
        throw new NotImplementedException();
    }
}

public class MyClass
{
    public void Test()
    {
        Test2();
    }

    private void Test2()
    {
        throw new NotImplementedException();
    }
}

public class GetFilmByIdQuery : GetFilmByIdQueryBase
{

    public int Id { get; set; }
    public override bool Equals(object? obj)
    {
        Console.WriteLine("");
        return base.Equals(obj);
    }
}

public abstract class DeleteAllFilmsCommand : IRequest
{
    private GetFilmByIdQuery? query;
    private void Test()
    {
        if (query?.Equals(null) != null)
        {
        }
    }
}