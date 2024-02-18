namespace SrDictionary.Objects
{
    public sealed class CObjChar : ObjCommon
    {
        public CObjChar() : base()
        {
            Bionic = 1;
            ReqLevelType1 = -1;
            ReqLevelType2 = -1;
            ReqLevelType3 = -1;
            ReqLevelType4 = -1;
        }
        public CObjChar(int id) : base(id)
        {
            Bionic = 1;
            ReqLevelType1 = -1;
            ReqLevelType2 = -1;
            ReqLevelType3 = -1;
            ReqLevelType4 = -1;
        }

        public byte Lvl { get; set; }
        public byte CharGender { get; set; }
        public int MaxHP { get; set; }
        public int ResistFrozen { get; set; }
        public int ResistFrostbite { get; set; }
        public int ResistBurn { get; set; }
        public int ResistEShock { get; set; }
        public int ResistPoison { get; set; }
        public int ResistZombie { get; set; }
        public int ResistSleep { get; set; }
        public int ResistRoot { get; set; }
        public int ResistSlow { get; set; }
        public int ResistFear { get; set; }
        public int ResistMyopia { get; set; }
        public int ResistBlood { get; set; }
        public int ResistStone { get; set; }
        public int ResistDark { get; set; }
        public int ResistStun { get; set; }
        public int ResistDisea { get; set; }
        public int ResistChaos { get; set; }
        public int ResistCsePD { get; set; }
        public int ResistCseMD { get; set; }
        public int ResistCseSTR { get; set; }
        public int ResistCseINT { get; set; }
        public int ResistCseHP { get; set; }
        public int ResistCseMP { get; set; }
        public int Resist24 { get; set; }
        public int ResistBomb { get; set; }
        public int Resist26 { get; set; }
        public int Resist27 { get; set; }
        public int Resist28 { get; set; }
        public int Resist29 { get; set; }
        public int Resist30 { get; set; }
        public int Resist31 { get; set; }
        public int Resist32 { get; set; }
        public byte InventorySize { get; set; }
        public byte CanStore_TID1 { get; set; }
        public byte CanStore_TID2 { get; set; }
        public byte CanStore_TID3 { get; set; }
        public byte CanStore_TID4 { get; set; }
        public bool CanBeVehicle { get; set; }
        public bool CanControl { get; set; }
        public int PD { get; set; }
        public int MD { get; set; }
        public int PAR { get; set; }
        public int MAR { get; set; }
        public int ER { get; set; }
        public int BR { get; set; }
        public int HR { get; set; }
        public int CHR { get; set; }
        public int ExpToGive { get; set; }
        public int CreepType { get; set; }
        public byte Knockdown { get; set; }
        public int KO_RecoverTime { get; set; }
        public int DefaultSkill_1 { get; set; }
        public int DefaultSkill_2 { get; set; }
        public int DefaultSkill_3 { get; set; }
        public int DefaultSkill_4 { get; set; }
        public int DefaultSkill_5 { get; set; }
        public int DefaultSkill_6 { get; set; }
        public int DefaultSkill_7 { get; set; }
        public int DefaultSkill_8 { get; set; }
        public int DefaultSkill_9 { get; set; }
        public int DefaultSkill_10 { get; set; }
        public byte TextureType { get; set; }
        public int Except_1 { get; set; }
        public int Except_2 { get; set; }
        public int Except_3 { get; set; }
        public int Except_4 { get; set; }
        public int Except_5 { get; set; }
        public int Except_6 { get; set; }
        public int Except_7 { get; set; }
        public int Except_8 { get; set; }
        public int Except_9 { get; set; }
        public int Except_10 { get; set; }
    }

}
