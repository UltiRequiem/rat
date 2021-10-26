# Rat

A [`cat`](https://en.wikipedia.org/wiki/Cat_(Unix)) clone.

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
mcs Program.cs -out:rat && sudo mv rat /usr/bin/rat # Or somewhere else in $PATH
```

## Usage

If you dont pass arguments it will print the stdin, just as `cat`.

```
rat
```

Using the `--number` flag:

```sh
rat --number Program.cs
```

Using the `--show-ends` flag:

```sh
rat --show-ends Program.cs
```

At the moment this options are supported:

- `--number`: Number all output lines

- `--show-ends`: Display "$" at the end of each line

## Note

This was the first project I did in `C#`, practically a "Hello world".

## License

This project is licensed under the [MIT License](./license).
