// C# Implementation

using System;

// Abstract Product A
interface IChair {
    void Create();
}

// Abstract Product B
interface ITable {
    void Create();
}

// Concrete Product A1
class ModernChair : IChair {
    public void Create() {
        Console.WriteLine("Modern Chair created.");
    }
}

// Concrete Product A2
class VictorianChair : IChair {
    public void Create() {
        Console.WriteLine("Victorian Chair created.");
    }
}

// Concrete Product B1
class ModernTable : ITable {
    public void Create() {
        Console.WriteLine("Modern Table created.");
    }
}

// Concrete Product B2
class VictorianTable : ITable {
    public void Create() {
        Console.WriteLine("Victorian Table created.");
    }
}

// Abstract Factory
interface IFurnitureFactory {
    IChair CreateChair();
    ITable CreateTable();
}

// Concrete Factory 1
class ModernFurnitureFactory : IFurnitureFactory {
    public IChair CreateChair() {
        return new ModernChair();
    }
    public ITable CreateTable() {
        return new ModernTable();
    }
}

// Concrete Factory 2
class VictorianFurnitureFactory : IFurnitureFactory {
    public IChair CreateChair() {
        return new VictorianChair();
    }
    public ITable CreateTable() {
        return new VictorianTable();
    }
}

// Client
class FurnitureStore {
    private IChair chair;
    private ITable table;

    public FurnitureStore(IFurnitureFactory factory) {
        chair = factory.CreateChair();
        table = factory.CreateTable();
    }

    public void CreateFurniture() {
        chair.Create();
        table.Create();
    }
}

class Program {
    static void Main() {
        Console.WriteLine("Modern Furniture Set:");
        FurnitureStore modernStore = new FurnitureStore(new ModernFurnitureFactory());
        modernStore.CreateFurniture();

        Console.WriteLine("\nVictorian Furniture Set:");
        FurnitureStore victorianStore = new FurnitureStore(new VictorianFurnitureFactory());
        victorianStore.CreateFurniture();
    }
}
