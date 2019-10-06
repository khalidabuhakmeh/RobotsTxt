# Robots.Txt Middleware

An ASP.NET Core Robots.txt middleware for the SEO conscientious.

Read more about it at [https://khalidabuhakmeh.com/robotstxt-middleware-aspnet-core](/robotstxt-middleware-aspnet-core)

## Getting Started

You will need the .NET Core 3.0 SDK from https://dot.net.

Register the middleware passing in the required parameters and then include `robots.txt` files based on your environment at the `rootpath` provided.

```txt
robots.txt
robots.Development.txt
robots.Staging.txt
robots.Production.txt
```

That's it! Your environment specific `robots.txt` should be served accordingly.

## Social

Also follow me on GitHub and on [Twitter](https://twitter.com/buhakmeh).

Cheers :)

Remember to #Hacktoberfest
