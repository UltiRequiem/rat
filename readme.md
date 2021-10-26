# Rat

A mini [`cat`](<https://en.wikipedia.org/wiki/Cat_(Unix)>) clone.

## Install

If you have installed
[`dotnet`](https://docs.microsoft.com/en-us/dotnet/core/tools):

```sh
dotnet tool install --global rat
```

If you have installed
[`msc`](https://www.mono-project.com/docs/about-mono/languages/csharp), The
Turbo C# Compiler, you can try the
[v1.0.0](https://github.com/UltiRequiem/rat/tree/v1.0.0), version:

```sh
git clone https://github.com/UltiRequiem/rat && cd rat && git checkout 423c4b7;
mcs Program.cs -out:rat && sudo mv rat /usr/bin/rat # Or somewhere else in the $PATH
```

## Usage

```sh
rat --number Program.cs
```

At the moment this options are supported:

- `--number`: number all output lines

- `--show-ends`: Display $ at the end of each line

## License

This project is licensed under the [MIT License](./license).
