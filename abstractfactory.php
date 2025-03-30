<?php

// Abstract Product A
interface Chair {
    public function create();
}

// Abstract Product B
interface Table {
    public function create();
}

// Concrete Product A1
class ModernChair implements Chair {
    public function create() {
        echo "Modern Chair created.\n";
    }
}

// Concrete Product A2
class VictorianChair implements Chair {
    public function create() {
        echo "Victorian Chair created.\n";
    }
}

// Concrete Product B1
class ModernTable implements Table {
    public function create() {
        echo "Modern Table created.\n";
    }
}

// Concrete Product B2
class VictorianTable implements Table {
    public function create() {
        echo "Victorian Table created.\n";
    }
}

// Abstract Factory
interface FurnitureFactory {
    public function createChair(): Chair;
    public function createTable(): Table;
}

// Concrete Factory 1
class ModernFurnitureFactory implements FurnitureFactory {
    public function createChair(): Chair {
        return new ModernChair();
    }
    public function createTable(): Table {
        return new ModernTable();
    }
}

// Concrete Factory 2
class VictorianFurnitureFactory implements FurnitureFactory {
    public function createChair(): Chair {
        return new VictorianChair();
    }
    public function createTable(): Table {
        return new VictorianTable();
    }
}

// Client
function createFurnitureSet(FurnitureFactory $factory) {
    $chair = $factory->createChair();
    $table = $factory->createTable();

    $chair->create();
    $table->create();
}

echo "Modern Furniture Set:\n";
createFurnitureSet(new ModernFurnitureFactory());

echo "\nVictorian Furniture Set:\n";
createFurnitureSet(new VictorianFurnitureFactory());
?>
