﻿using System;

namespace SkiaSharp
{
	public class SKNoDrawCanvas : SKCanvas
	{
		[Preserve]
		internal SKNoDrawCanvas (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}

		public SKNoDrawCanvas (int width, int height)
			: this (SkiaApi.sk_nodraw_canvas_new (width, height), true)
		{
		}
	}
}
