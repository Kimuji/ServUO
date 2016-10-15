using Server;
using System;

namespace Server.Items
{
    public class MaleKimonoBearingTheCrestOfBlackthorn4 : MaleKimono
    {
        public override bool IsArtifact { get { return true; } }
        
        [Constructable]
        public MaleKimonoBearingTheCrestOfBlackthorn4()
            : base()
        {
            ReforgedSuffix = ReforgedSuffix.Blackthorn;
            Attributes.BonusHits = 3;
            Attributes.BonusInt = 5;
            Hue = 2107;
        }

        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }

        public MaleKimonoBearingTheCrestOfBlackthorn4(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}