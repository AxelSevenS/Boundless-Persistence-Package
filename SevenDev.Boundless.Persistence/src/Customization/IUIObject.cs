namespace SevenDev.Boundless.Persistence;

using System.Collections.Generic;
using Godot;

public interface IUIObject {
	string DisplayName { get; }
	Texture2D? DisplayPortrait { get; }

	IEnumerable<IUIObject> GetSubObjects() => [];
}