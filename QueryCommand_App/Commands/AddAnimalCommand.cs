﻿using Castle.Components.DictionaryAdapter.Xml;
using QueryCommand_App.CommandModels;

namespace QueryCommand_App.Commands;

public class AddAnimalCommand:ICommand
{
    public void Execute(AnimalCommandModel animal)
    {
        var componentType = this.GetComponentType();
        var context = Helper.GetContext();
        context.Animals.Add(animal.ToAnimal());
        context.SaveChanges();
    }
}

public interface ICommand
{
    void Execute(AnimalCommandModel animal);
    //comment
}