using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetCargoManager : MonoBehaviour {

    List<Pet> pets;

    List<PetType> prohibitedPetTypes;
    
    List<int> maxPetsOfTypeAllowed;
    int maxPetsAllowed = 3;
    string lostPetName = "Bubbly";
    string lostPetType;

    void Start() {

        prohibitedPetTypes = new List<PetType> {
            PetType.Pangolin
        };
        
        
        pets = new List<Pet> {
            new SolidFoodPet("Rex", PetType.Dog),
            new SolidFoodPet("Fluffy", PetType.Cat),
            new SolidFoodPet("Princess", PetType.Cat),
            new SolidFoodPet("Tiger", PetType.Cat),
            new SolidFoodPet("Meany", PetType.Cat),
            new FlakeFoodPet("Bubbly", PetType.Fish ),
            new SolidFoodPet("Cutey", PetType.Pangolin),
            
        };
        
       
        maxPetsOfTypeAllowed = new List<int> {
            1,
            4,
            1,
            1,
        };
        
        ListPetInfo();
        ProhibitedPet();
        FeedPets();
        //TODO CheckTooManyPets();
        //TODO LostPetFound();
    }

    void FeedPets() {
        foreach (Pet pet in pets) {
            pet.Feed();
        }
    }

    void ListPetInfo() {
        foreach (Pet pet in pets) {
            pet.PrintInfo();
        }
    }


    
    void ProhibitedPet() {
        foreach (PetType prohibitedPetType in prohibitedPetTypes) {
            foreach (Pet pet in pets) {
                if (pet.PetType == prohibitedPetType) {
                    Debug.Log($"Match! {prohibitedPetType}, {pet.PetType}");
                }
            }
        }
    }
    
    // void CheckTooManyPets() {
    //     for (int i = 0; i < maxPetsOfTypeAllowed.Count; i++) {
    //         int n = maxPetsOfTypeAllowed[i];
    //         if (n >= maxPetsAllowed) {
    //             Debug.Log($"Too many {petTypes[i]} ({maxPetsOfTypeAllowed[i]})");
    //         }
    //     }
    // }
    
    // void LostPetFound() {
    //     for (int i = 0; i < petNames.Count; i++) {
    //         lostPetType = "Fish";
    //         if (petNames[i] == lostPetName && petTypes[i] == lostPetType) {
    //             Debug.Log($"Lost pet found: {petTypes[i]} named {petNames[i]}");
    //         }
    //     }
    // }
    
    
}