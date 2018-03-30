﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour {
    public GameObject TreePrefab;
    public int minTrees = 1;
    public int maxTrees = 15;
	// Use this for initialization
	void Start () {
        int treeNumber = Random.Range(minTrees, maxTrees);
        for(int i = 0; i < treeNumber; i++)
        {
            CreateTree();
        }
        
    }
	
    void CreateTree()
    {
        var tree = Instantiate(TreePrefab);
        tree.transform.parent = transform;
        tree.transform.localPosition = new Vector3(Random.Range(-5000, 5000), 0, Random.Range(-500, 500));
    }
	// Update is called once per frame
	void Update () {
		
	}
}
