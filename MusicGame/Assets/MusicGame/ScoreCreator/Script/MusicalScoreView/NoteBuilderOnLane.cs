using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Notetype = NoteInfoGeneral.NoteType;

public class NoteBuilderOnLane : SingletonMonoBehaviour<NoteBuilderOnLane>
{
    /// <summary>
    /// 各ノートタイプとその原本を紐づけます.
    /// </summary>
    [Serializable]
    class BindNotetypeToOriginObject
    {
        public Notetype noteType; // ノートの種類
        public GameObject originObject; // オブジェクト原本
    }

    /// <summary>
    /// 原本の集まりです.
    /// </summary>
    [SerializeField]
    private List<BindNotetypeToOriginObject> _originObejctList;

    /// <summary>
    /// レーン上に表示するノートを作成します.
    /// </summary>
    /// <returns></returns>
    public GameObject CreateNoteOnLane(Notetype noteType)
    {
        GameObject ret = null;

        var originData = _originObejctList.FirstOrDefault( data => data.noteType == noteType );

        if( originData != null )
        {
            ret = originData.originObject;
        }

        return ret;
    }

}
