using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NoteType = NoteInfoGeneral.NoteType;

/// <summary>
/// ノート生成を行います.
/// </summary>
public static class NoteBuilder
{
    /// <summary>
    /// ノートを生成します.
    /// </summary>
    public static void BuildNote( BaseNoteInfo noteInfo )
    {
        // TODO: 各タイプごとの生成処理.

        switch ( noteInfo.NoteType )
        {
            default:
                Debug.LogError("Unregist note type. plz regist build method.[NoteBuilder.BuildNote]");
                break;
        }
    }
}
