﻿namespace Microsoft.Maui
{
	public interface IPositionInfo
	{
		bool IsSelected { get; set; }

		PositionKind Kind { get; set; }

		int SectionIndex { get; set; }

		int NumberOfSections { get; set; }

		int ItemIndex { get; set; }
		int ItemsInSection { get; set; }

		public bool IsLastItemInSection => ItemIndex >= ItemsInSection - 1;
		public bool IsNotLastItemInSection => !IsLastItemInSection;
		public bool IsFirstItemInSection => ItemIndex == 0;
		public bool IsNotFirstItemInSection => !IsFirstItemInSection;
	}
}
