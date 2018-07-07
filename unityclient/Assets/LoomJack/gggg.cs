﻿using System.Collections;
using System.Collections.Generic;
using Loom.BlackJack;
using Loom.Unity3d;
using Loom.Unity3d.Samples.TilesChainEvm;
using UnityEngine;

public class gggg : MonoBehaviour
{
    private BlackJackContractClient client;

	// Use this for initialization
	void Start () {
	    var privateKey = CryptoUtils.GeneratePrivateKey();
	    var publicKey = CryptoUtils.PublicKeyFromPrivateKey(privateKey);
	    this.client = new BlackJackContractClient("", privateKey, publicKey, Debug.unityLogger);
	}
}
