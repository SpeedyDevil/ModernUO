namespace Server.Mobiles
{
    public class ArcaneFey : BaseCreature
    {
        [Constructible]
        public ArcaneFey() : base(AIType.AI_Mage, FightMode.Evil)
        {
            Name = NameList.RandomName("pixie");
            Body = 128;
            BaseSoundID = 0x467;

            SetSpeed(0.3, 1.0);
            SetStr(20);
            SetDex(150);
            SetInt(125);

            SetDamage(9, 15);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 80, 90);
            SetResistance(ResistanceType.Fire, 40, 50);
            SetResistance(ResistanceType.Cold, 40, 50);
            SetResistance(ResistanceType.Poison, 40, 50);
            SetResistance(ResistanceType.Energy, 40, 50);

            SetSkill(SkillName.EvalInt, 70.1, 80.0);
            SetSkill(SkillName.Magery, 70.1, 80.0);
            SetSkill(SkillName.Meditation, 70.1, 80.0);
            SetSkill(SkillName.MagicResist, 50.5, 100.0);
            SetSkill(SkillName.Tactics, 10.1, 20.0);
            SetSkill(SkillName.Wrestling, 10.1, 12.5);

            Fame = 0;
            Karma = 0;

            ControlSlots = 1;
        }

        public ArcaneFey(Serial serial) : base(serial)
        {
        }

        public override string CorpseName => "a pixie corpse";
        public override double DispelDifficulty => 70.0;
        public override double DispelFocus => 20.0;

        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;
        public override bool InitialInnocent => true;

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);
            var version = reader.ReadInt();
        }
    }
}
