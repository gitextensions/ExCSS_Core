﻿namespace ExCSS.Tests
{
	using ExCSS;
	using Xunit;

	//[TestFixture]
	public class FillPropertyTests : CssConstructionFunctions
	{
		[Fact]//[Test]
		public void FillColorRedLegal()
		{
			var snippet = "fill: red";
			var property = ParseDeclaration(snippet);
			Assert.Equal("fill", property.Name);
			Assert.False(property.IsImportant);
			Assert.IsType<FillProperty>(property);
			var concrete = (FillProperty)property;
			Assert.False(concrete.IsInherited);
			Assert.True(concrete.HasValue);
			Assert.Equal("rgb(255, 0, 0)", concrete.Value);
		}

		[Fact]//[Test]
		public void FillColorHexLegal()
		{
			var snippet = "fill: #0F0";
			var property = ParseDeclaration(snippet);
			Assert.Equal("fill", property.Name);
			Assert.False(property.IsImportant);
			Assert.IsType<FillProperty>(property);
			var concrete = (FillProperty)property;
			Assert.False(concrete.IsInherited);
			Assert.True(concrete.HasValue);
			Assert.Equal("rgb(0, 255, 0)", concrete.Value);
		}

		[Fact]//[Test]
		public void FillColorRgbaLegal()
		{
			var snippet = "fill: rgba(1, 1, 1, 0)";
			var property = ParseDeclaration(snippet);
			Assert.Equal("fill", property.Name);
			Assert.False(property.IsImportant);
			Assert.IsType<FillProperty>(property);
			var concrete = (FillProperty)property;
			Assert.False(concrete.IsInherited);
			Assert.True(concrete.HasValue);
			Assert.Equal("rgba(1, 1, 1, 0)", concrete.Value);
		}

		[Fact]//[Test]
		public void FillColorRgbLegal()
		{
			var snippet = "fill: rgb(1, 255, 100)";
			var property = ParseDeclaration(snippet);
			Assert.Equal("fill", property.Name);
			Assert.False(property.IsImportant);
			Assert.IsType<FillProperty>(property);
			var concrete = (FillProperty)property;
			Assert.False(concrete.IsInherited);
			Assert.True(concrete.HasValue);
			Assert.Equal("rgb(1, 255, 100)", concrete.Value);
		}

		[Fact]//[Test]
		public void FillNoneLegal()
		{
			var snippet = "fill: none";
			var property = ParseDeclaration(snippet);
			Assert.Equal("fill", property.Name);
			Assert.False(property.IsImportant);
			Assert.IsType<FillProperty>(property);
			var concrete = (FillProperty)property;
			Assert.False(concrete.IsInherited);
			Assert.True(concrete.HasValue);
			Assert.Equal("none", concrete.Value);
		}

		[Fact]//[Test]
		public void FillColorRedRedIllegal()
		{
			var snippet = "fill: red red";
			var property = ParseDeclaration(snippet);
			Assert.Equal("fill", property.Name);
			Assert.False(property.IsImportant);
			Assert.IsType<FillProperty>(property);
			var concrete = (FillProperty)property;
			Assert.False(concrete.IsInherited);
			Assert.False(concrete.HasValue);
		}

		[Fact]//[Test]
		public void FillUrlLegal()
		{
			var snippet = "fill: url(#linear)";
			var property = ParseDeclaration(snippet);
			Assert.Equal("fill", property.Name);
			Assert.False(property.IsImportant);
			Assert.IsType<FillProperty>(property);
			var concrete = (FillProperty)property;
			Assert.False(concrete.IsInherited);
			Assert.True(concrete.HasValue);
			Assert.Equal("url(\"#linear\")", concrete.Value);
		}

		[Fact]//[Test]
		public void FillOpacitytNumberLegal()
		{
			var snippet = "fill-opacity: 0.5";
			var property = ParseDeclaration(snippet);
			Assert.Equal("fill-opacity", property.Name);
			Assert.False(property.IsImportant);
			Assert.IsType<FillOpacityProperty>(property);
			var concrete = (FillOpacityProperty)property;
			Assert.False(concrete.IsInherited);
			Assert.True(concrete.HasValue);
			Assert.Equal("0.5", concrete.Value);
		}

		[Fact]//[Test]
		public void FillOpacityNumberNumberIllegal()
		{
			var snippet = "fill-opacity: 0.5 0.5";
			var property = ParseDeclaration(snippet);
			Assert.Equal("fill-opacity", property.Name);
			Assert.False(property.IsImportant);
			Assert.IsType<FillOpacityProperty>(property);
			var concrete = (FillOpacityProperty)property;
			Assert.False(concrete.IsInherited);
			Assert.False(concrete.HasValue);
		}
	}
}
