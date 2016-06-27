// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannelForbidden : TLChatBase 
	{
		[Flags]
		public enum Flag : int
		{
			Broadcast = (1 << 5),
			Megagroup = (1 << 8),
		}

		public bool IsBroadcast { get { return Flags.HasFlag(Flag.Broadcast); } set { Flags = value ? (Flags | Flag.Broadcast) : (Flags & ~Flag.Broadcast); } }
		public bool IsMegagroup { get { return Flags.HasFlag(Flag.Megagroup); } set { Flags = value ? (Flags | Flag.Megagroup) : (Flags & ~Flag.Megagroup); } }

		public Flag Flags { get; set; }
		public Int64 AccessHash { get; set; }

		public TLChannelForbidden() { }
		public TLChannelForbidden(TLBinaryReader from, TLType type = TLType.ChannelForbidden)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ChannelForbidden; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ChannelForbidden)
		{
			Flags = (Flag)from.ReadInt32();
			Id = from.ReadInt32();
			AccessHash = from.ReadInt64();
			Title = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x8537784F);
			to.Write((Int32)Flags);
			to.Write(Id);
			to.Write(AccessHash);
			to.Write(Title);
		}
	}
}