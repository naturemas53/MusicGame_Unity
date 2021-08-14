using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NoteInfoGeneral
{
    /// <summary>
    /// ノートの種類.
    /// </summary>
    public enum NoteType
    {
        None,   // 何でもない...
        Single, // 単押し
        Long,   // 長押し
    }
}
