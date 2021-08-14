using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 単押しノートの情報
/// ...とはいえ基本情報で事足りてはいるので、
/// 別になにも追加しない。（しいて言うならノートの種類だけ？）
/// </summary>
public sealed class SingleNoteInfo : BaseNoteInfo
{
    public override NoteInfoGeneral.NoteType NoteType { get; protected set; } = NoteInfoGeneral.NoteType.Single;
}
