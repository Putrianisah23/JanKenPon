using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PropertyNames
{
    //!Suatu class enum supaya gak typo di avatarselector.cs
    public static class Player {
        public const string AvatarIndex = "AvatarIndex";
        public const string NickName = "NickName";
    }

    public static class Room {
        public const string MaxHealth = "MaxHealth";
        public const string RestoreValue = "RestoreValue";
        public const string DamageValue = "DamageValue";

    }
}