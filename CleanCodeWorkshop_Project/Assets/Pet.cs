using UnityEngine;

public abstract class Pet {
    protected string petName;
    protected PetType petType;

    public string PetName => petName;
    public PetType PetType => petType;

    public Pet(string petName, PetType petType) {
        this.petName = petName;
        this.petType = petType;
    }


    public void PrintInfo() {
        Debug.Log($"{petType} named {petName}");
    }

    public abstract void Feed();


}

public class FlakeFoodPet : Pet {
    public FlakeFoodPet(string petName, PetType petType) 
        : base(petName, petType) { }

    public override void Feed() {
        Debug.Log($"Feeding {petName} flake food");
        Debug.Log($"Feeding {petName} give tummy scraches");
    }
}

public class SolidFoodPet : Pet {
    public SolidFoodPet(string petName, PetType petType) 
        : base(petName, petType) { }
    
    public override void Feed() {
        Debug.Log($"Feeding {petName} solid food");
    }
}