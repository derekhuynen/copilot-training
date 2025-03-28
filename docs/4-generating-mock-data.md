# Lesson 5: Generating Mock Data with GitHub Copilot

## Overview

**Goal:**  
In this lesson, you'll learn how GitHub Copilot can help generate mock data for your projects. We'll cover:

- Generating mock data in TypeScript when provided with a type.
- Generating mock JSON data that reflects SQL relationships.

By the end of this lesson, you'll see how to use Copilot to accelerate your test data creation and simulate realistic data structures for your application.

**Estimated Duration:**  
10-15 minutes

**Audience:**  
Developers looking to improve their productivity by automating mock data generation for testing and prototyping.

**Prerequisites:**

- **Access to GitHub Copilot:** An active GitHub Copilot subscription.
- **Visual Studio Code (VS Code):** Installed and set up for development.
- **GitHub Copilot Extension for VS Code:** Installed and properly configured.

> **Note:** If you haven't completed the setup steps, please refer to [Lesson 1: Installing and Configuring GitHub Copilot](docs/1-installing-copilot.md).

---

## Example 1: Generating Mock Data in TypeScript from a Type

Imagine you have the following TypeScript interface for a `User`:

```typescript
interface User {
	id: number;
	name: string;
	email: string;
	isActive: boolean;
}
```

```plaintext
 Generate mock data for the User type. Create a json array of 10 users with random values for each field.

 interface User {
  id: number;
  name: string;
  email: string;
  isActive: boolean;
}
```

## Example 2: Generating Mock JSON Data with SQL Relationships

Now, let's consider a more complex scenario where you need to generate mock JSON data that reflects SQL relationships. Suppose you have the following SQL tables:

```sql
CREATE TABLE users (
  id INT PRIMARY KEY,
  name VARCHAR(255),
  email VARCHAR(255),
  isActive BOOLEAN
);

CREATE TABLE posts (
  id INT PRIMARY KEY,
  title VARCHAR(255),
  content TEXT,
  userId INT,
  FOREIGN KEY (userId) REFERENCES users(id)
);
```

```plaintext
Generate mock JSON data for the users and posts tables. Ensure that the posts table has a userId that corresponds to an existing user id.

CREATE TABLE users (
  id INT PRIMARY KEY,
  name VARCHAR(255),
  email VARCHAR(255),
  isActive BOOLEAN
);

CREATE TABLE posts (
  id INT PRIMARY KEY,
  title VARCHAR(255),
  content TEXT,
  userId INT,
  FOREIGN KEY (userId) REFERENCES users(id)
);
```
