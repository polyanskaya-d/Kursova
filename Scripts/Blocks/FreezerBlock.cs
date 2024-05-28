﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezerBlock : Block
{
    // Start is called before the first frame update
    void Start()
    {
        scorePoints = ConfigurationUtils.FreezerBlockScorePoints;
        _blockType = BlockType.Freezer;
    }
}
