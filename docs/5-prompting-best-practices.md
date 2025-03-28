# Slide: Crafting Effective Prompts

## Elements of an Effective Prompt

Effective prompts give Security Copilot the parameters it needs to generate valuable responses. Include these elements in every prompt:

- **Goal:**  
  Define the specific, security-related information you need (e.g., list of indicators, incident summary).

- **Context:**  
  Explain why you need the information or how you plan to use it (e.g., timeframe, report for management).

- **Expectations:**  
  Specify the format or target audience (e.g., table, list of action steps, summary, diagram).

- **Source:**  
  Identify known data, data sources, or plugins (e.g., Microsoft Defender XDR, specific Microsoft plugins).

---

## Other Prompting Tips

- **Be Specific, Clear, and Concise:**  
  Start with a simple prompt, then add more details as you become familiar with Copilot’s responses.

- **Iterate:**  
  Refine subsequent prompts to further clarify your requirements.

- **Provide Necessary Context:**  
  Narrow down where Security Copilot should look for data.

- **Use Positive Instructions:**  
  Tell it what you want it to do rather than what not to do.

- **Direct Address:**  
  Speak directly to Security Copilot (e.g., "You must provide...").

---

## Improved Prompt Examples

### Example 1: .NET Application Error Analysis

- **Basic prompt:**  
  `Get error logs`

- **Improved prompt:**  
  `Using Microsoft Application Insights, generate a detailed summary of the top 5 error logs in our .NET web application over the past 7 days. Include error messages, stack traces, and the names of the affected modules.`

---

### Example 2: React Component for Security Dashboard

- **Basic prompt:**  
  `Create a React component`

- **Improved prompt:**  
  `Develop a functional React component in TypeScript that displays a dashboard of high-risk security alerts. The component should fetch data from a REST API, show a loading state while fetching, and use Material-UI for styling. Include error handling and a clear UI layout.`

---

### Example 3: .NET Data Filtering Method

- **Basic prompt:**  
  `Filter orders`

- **Improved prompt:**  
  `Implement a C# method using LINQ that filters a list of orders to return only those with a TotalAmount greater than $200 and then sorts them by OrderDate in descending order. Ensure to include proper error handling and comments explaining the logic.`

---

## Summary

- Structure your prompts with **Goal, Context, Expectations, and Source.**
- Refine your instructions iteratively.
- Use natural language and direct instructions to maximize clarity.

Happy prompting!
