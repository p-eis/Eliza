using MessagePack;

namespace Eliza.Model.Farm
{
    public class FarmManager
    {
        public static BitVector32Int.Section si0_grow_spd => BitVector32Int.CreateSection(11);
        public static BitVector32Int.Section si0_grow_num => BitVector32Int.CreateSection(11, 11);
        public static BitVector32Int.Section si0_grow_lvl => BitVector32Int.CreateSection(10, 22);
        public static BitVector32Int.Section si1_grow_size => BitVector32Int.CreateSection(10);
        public static BitVector32Int.Section si1_def => BitVector32Int.CreateSection(6, 10);
        public static BitVector32Int.Section si1_hp => BitVector32Int.CreateSection(8, 16);
        public static BitVector32Int.Section si1_atk => BitVector32Int.CreateSection(5, 24);
        public static BitVector32Int.Section si1_doping => BitVector32Int.CreateSection(2, 29);
        public static BitVector32Int.Section si1_work_on_crop => BitVector32Int.CreateSection(1, 31);
        public static BitVector32Int.Section si2_rp => BitVector32Int.CreateSection(4);
        public static BitVector32Int.Section si2_soil_num_lvl => BitVector32Int.CreateSection(4, 4);
        public static BitVector32Int.Section si2_soil_lvl_lvl => BitVector32Int.CreateSection(4, 8);
        public static BitVector32Int.Section si2_soil_size_lvl => BitVector32Int.CreateSection(4, 12);
        public static BitVector32Int.Section si2_soil_exp => BitVector32Int.CreateSection(8, 16);
        public static BitVector32Int.Section si2_soil_spd_exp => BitVector32Int.CreateSection(8, 24);
        public static BitVector32Int.Section si3_soil_num_exp => BitVector32Int.CreateSection(8);
        public static BitVector32Int.Section si3_soil_lvl_exp => BitVector32Int.CreateSection(8, 8);
        public static BitVector32Int.Section si3_soil_size_exp => BitVector32Int.CreateSection(8, 16);
        public static BitVector32Int.Section si3_soil_lvl => BitVector32Int.CreateSection(4, 24);
        public static BitVector32Int.Section si3_soil_spd_lvl => BitVector32Int.CreateSection(4, 28);
    }

    [MessagePackObject]
    public class RF4_CROP_STATE
    {
        // Fields
        [Key(0)]
        public RF4_CROP_STATE_INFO info;
        [Key(1)]
        public RF4_MCROP_INFO pMcrop;
        [Key(2)]
        public int pSoil;
        [Key(3)]
        public int flag;
        [Key(4)]
        public byte size;
        [Key(5)]
        public int crop_grow_state;
        [Key(6)]
        public byte die_flag;
        [Key(7)]
        public bool disp_cul;
        [Key(8)]
        public bool disp_cul_w;
        [Key(9)]
        public byte farm_id;
    }

    [MessagePackObject]
    public class RF4_CROP_STATE_INFO
    {
        [Key(0)]
        public BitVector32Int csi0;
        [Key(1)]
        public BitVector32Int csi1;
        [Key(2)]
        public BitVector32Int csi2;
        [Key(3)]
        public BitVector32Int csi3;
        [Key(4)]
        public int cell_id;
    }

    [MessagePackObject]
    public class RF4_MCROP_INFO
    {
        [Key(0)]
        public int enable;
        [Key(1)]
        public int mcrop_map_id;
        [Key(2)]
        public int mcrop_hp;
    }

    [MessagePackObject]
    public class RF4_SOIL_INFO
    {
        [Key(0)]
        public BitVector32Int SI0;
        [Key(1)]
        public BitVector32Int SI1;
        [Key(2)]
        public BitVector32Int SI2;
        [Key(3)]
        public BitVector32Int SI3;
    }
}
