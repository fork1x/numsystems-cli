# numsystems-cli

A simple interactive console application written in C# for learning and converting numbers between different numeral systems.

## Features

- **Conversion** — convert any decimal number (0–1,000,000) to Binary, Octal, and Hexadecimal
- **Binary system** — learn what it is, why computers use it, units (bit/byte), and how to count
- **Decimal system** — learn its structure and positional weights
- **Hexadecimal system** — learn its characters, use cases, and positional weights
- Colorful console UI with fixed window sizing

## Menu Options

| Key | Action |
|-----|--------|
| `1` | Convert decimal number to BIN / OCT / HEX |
| `2` | Info about the binary system |
| `3` | Info about the decimal system |
| `4` | Info about the hexadecimal system |
| `5` / `Esc` | Exit the program |

## Requirements

- [.NET 8.0+](https://dotnet.microsoft.com/download)
- OS: Windows (uses `Console.SetWindowSize` which is Windows-only)

## Getting Started

```bash
git clone https://github.com/fork1x/numsystems-cli.git
cd numsystems-cli
dotnet run
