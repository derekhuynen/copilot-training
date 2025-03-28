# Lesson 3: Using `@` Commands with GitHub Copilot

## Overview

**Goal:**  
In this lesson, you'll learn how to use the `@` syntax with GitHub Copilot to reference specific contexts in your code. In particular, you'll see how to use `@workspace` and `@azure` to get context-aware code suggestions.

By the end of this lesson, you will:

- Understand how the `@` prefix can signal contextual requests.
- See examples of how `@workspace` can pull in project-specific code.
- Learn how `@azure` can help with Azure-specific code snippets.

**Estimated Duration:**  
10-15 minutes

**Audience:**  
Developers looking to leverage GitHub Copilot's contextual suggestions to speed up development and maintain consistency across codebases.

---

## What is the `@` Syntax?

GitHub Copilot supports using the `@` prefix in code comments or inline notes to provide extra context. These tags guide Copilot in offering more relevant suggestions based on your project's workspace or specific technologies like Azure.

---

## Example 1: Using `@workspace`

When you add `@workspace` in a comment, Copilot understands that you want suggestions from the context of your current project files. For example, you can ask copilot to exmaplin what a repository is doing.

```plaintext
// @workspace: What does the project /frontend do?
```

## Example 2: Using `@azure`

If you're working with Azure services, you can use `@azure` to get suggestions tailored to Azure-specific code snippets. Or you can just ask copilot about specific Azure services.

```plaintext
@azure What are the different tiers available for blob storage?

```

This does require you to be logged into your Azure account and have the Azure extension installed in Visual Studio Code.
