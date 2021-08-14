using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// 基礎のノート情報
/// 全ノートで共通するノート情報を追加します
/// </summary>
public class BaseNoteInfo
{
    virtual public NoteInfoGeneral.NoteType NoteType { get; protected set; } = NoteInfoGeneral.NoteType.None; // ノートの種類.
    public float startTime = 0.0f; // ノート開始時間.
}
