using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListPrinter : MonoBehaviour {

    List<string> a;
    List<string> b;
    List<int> c;

    void Start() {
        b = new List<string> {
            "Dog",
            "Cat",
            "Fish",
            "Pangolin",
        };
        a = new List<string> {
            "Rex",
            "Fluffy, Princess, Tiger, Meany",
            "Bubbly",
            "Cutey",
        };
        c = new List<int> {
            1,
            4,
            1,
            1,
        };
        
        PrintList();
        PrintListB();
        CheckMatch();
        DoCheck();
        DoCheck2();
    }


    void PrintList() {
        for (int i = 0; i < a.Count; i++) {
            Debug.Log(a[i]);
        }
    }
    
 
    void PrintListB() {
        for (int i = 0; i < b.Count; i++) {
            Debug.Log($"{b[i]} named {a[i]}");
        }
    }

  
    void CheckMatch() {
        for (int i = 0; i < a.Count; i++) {
            for (int j = 0; j < b.Count; j++) {
                if (a[i] == b[j]) {
                    Debug.Log($"Match! {a[i]}, {b[j]}");
                }
            }
        }
    }
    
    void DoCheck() {
        for (int i = 0; i < c.Count; i++) {
            int n = c[i];
            if (n >= 3) {
                Debug.Log($"Too many {b[i]} ({c[i]})");
            }
        }
    }
    
    void DoCheck2() {
        for (int i = 0; i < a.Count; i++) {
            if (a[i] == "Bubbly" && b[i] == "Fish") {
                Debug.Log($"Lost pet found: {b[i]} named {a[i]}");
            }
        }
    }
    
    
    

}
