# Reor.Illustrations.OpenDoodles

A .NET library that brings [Pablo Stanley's OpenDoodles](https://www.opendoodles.com/) to the dotnet ecosystem. All 32 doodle illustrations are available as SVG strings with customizable colors.

## Installation

Install via NuGet:

```bash
dotnet add package Reor.Illustrations.OpenDoodles
```

Or via Package Manager:

```
Install-Package Reor.Illustrations.OpenDoodles
```

## Quick Start

### Default Colors

Use any doodle with sensible defaults (black foreground, red accent, white background):

```csharp
using Reor.Illustrations;

var svg = OpenDoodles.Dancing;
// Returns SVG string ready to render
```

### Custom Colors

Get the same doodle with your own colors:

```csharp
using System.Drawing;
using Reor.Illustrations;

var foreground = Color.FromArgb(0, 0, 0);      // Black
var accent = Color.FromArgb(255, 97, 97);      // Red
var background = Color.FromArgb(0, 255, 255, 255);  // White (with transparency)

var svg = OpenDoodleSvgs.Dancing(foreground, accent, background);
```

## Available Doodles

All doodles are exposed as static properties on `OpenDoodles`:

- Ballet
- Bikini
- Coffee
- Dancing
- DogJump
- Doogie
- Dumping
- Float
- Groovy
- GroovySitting
- IceCream
- Laying
- Loving
- Meditating
- Messy
- Moshing
- Petting
- Plant
- Reading
- ReadingSide
- RollerSkating
- Rolling
- Running
- Selfie
- SitReading
- Sitting
- Sleek
- Sprinting
- Strolling
- Swinging
- Unboxing
- Zombieing

## Usage Example

Render a doodle in a web application:

```csharp
@{
    var dancing = OpenDoodles.Dancing;
}

<div>@Html.Raw(dancing)</div>
```

Or in a Blazor component:

```razor
@using Reor.Illustrations

<div>@((MarkupString)OpenDoodles.Dancing)</div>
```

## Color Customization

Each doodle has three customizable color zones:

- **Foreground** - The main illustration lines/details (default: `#000000`)
- **Accent** - Secondary colored elements (default: `#ff6161`)
- **Background** - The background fill (default: `#FFFFFF00`)

```csharp
var myGreen = Color.FromArgb(76, 175, 80);
var myBlue = Color.FromArgb(33, 150, 243);
var transparent = Color.FromArgb(0, 255, 255, 255);

var customSvg = OpenDoodleSvgs.Plant(myGreen, myBlue, transparent);
```

## License

These illustrations are from [OpenDoodles](https://www.opendoodles.com/) by Pablo Stanley, licensed under [CC0 1.0 Universal](https://creativecommons.org/publicdomain/zero/1.0/). You are free to use them for any purpose without attribution.

This package wrapper is licensed under the MIT License.
