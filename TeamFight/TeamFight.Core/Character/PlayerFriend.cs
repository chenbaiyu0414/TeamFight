﻿// ****************************************
// FileName:PlayerFriend.cs
// Description:
// Tables:Nothing
// Author:陈柏宇
// Create Date:2017-06-16
// Revision History:
// ****************************************

namespace TeamFight.Core.Character
{
    public class PlayerFriend
    {
        /// <summary>
        /// 好友角色Id
        /// </summary>
        public int FriendId { get; private set; }

        /// <summary>
        /// 好友姓名
        /// </summary>
        public string FriendName { get; set; }

        /// <summary>
        /// 好友战力
        /// </summary>
        public uint FriendCe { get; private set; }

        /// <summary>
        /// 好友性别
        /// </summary>
        public bool FriendGender { get; private set; }

        /// <summary>
        /// 好友是否在线
        /// </summary>
        public bool IsOnline { get; set; }

        public PlayerFriend(int id, string name, uint ce, bool gender)
        {
            FriendId = id;
            FriendName = name;
            FriendCe = ce;
            FriendGender = gender;
        }
    }
}