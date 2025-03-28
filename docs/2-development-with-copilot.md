# Lesson 2: Development with GitHub Copilot

## Overview

**Goal:**  
In this lab, you will explore and utilize various GitHub Copilot features, including autocomplete, inline chat, chat view, Copilot CLI, and Copilot Edits (preview), to enhance the **Ordering.Domain**. You will add a method to calculate order totals, incorporating discounts and taxes. Additionally, you will learn how to use Copilot to:

- Generate new code and improve existing code.
- Understand code efficiently using chat-based interactions.
- Refactor and optimize code using Copilot Edit.

By the end of this lab, you will have enhanced the `OrderService` with a comprehensive `GetTotal` method and gained practical experience with Copilot's full suite of features.

**Estimated Duration:**  
30-45 minutes

**Audience:**  
 Developers, QA testers, DevOps engineers, and Technical Writers.

**Prerequisites:**  
To successfully complete this lab, ensure you have the following:

- **Access to GitHub Copilot:** You must have an active GitHub Copilot subscription.
- **Visual Studio Code (VS Code):** Installed and set up for development.
- **GitHub Copilot Extension for VS Code:** Installed and properly configured in VS Code.

> **Note:** If you have not completed any of the above steps, please refer to - [Lesson 1: Installing and Configuring GitHub Copilot](docs/1-installing-copilot.md) for detailed instructions.

## Copilot Chat

GitHub Copilot Chat provides an interactive way to engage with Copilot, offering more space and deeper ways to interact with your code. With the Chat View, you can ask natural language questions about the current context in your editor, request code suggestions, and optimize your code with Copilot's help.

1. Open the Copilot Chat pane in Visual Studio Code by clicking the Copilot icon in the sidebar or using the command palette (`Ctrl+Alt+I`). In the chat settings, ensure the model is set to GPT 4o. If it’s not already selected, switch the model to GPT 4o in the Copilot settings.
   > **Note**: We will use this model for this lesson. In later lessons we will experiment with utilizing other models for various tasks such as testing and documentation.
2. In the Chat View prompt, you can use natural language to ask about current context (files open in the editor)

   - For example, browse to `api/src/Service` folder and open 'OrderService.cs' file.
   - Enter "how does this service work?"
   - Observe the GitHub Copilot response.
   - Alternatively, you can just enter one of the / commands, like /explain to get similar result.
   - You can continue dialog within the same context.  
      &emsp;For example, enter "How can i upgrade this Service to calculate total for orders" and press Enter.
   - Observe the suggested code changes.

3. (Optional) You can copy parts of or the whole suggested code and paste in the editor manually, or click appropriate icon above the code view to Insert at Cursor, Apply in Editor, or just copy to clipboard.
4. (Optional) Save the file.

**Additional Notes**
For more details on these, see [Getting started with prompts for Copilot Chat](https://docs.github.com/en/copilot/using-github-copilot/guides-on-using-github-copilot/getting-started-with-prompts-for-copilot-chat)

## Inline Chat

Now, let’s start by enhancing the OrderingService by leveraging inline chat feature. Our task is to add a method for calculating order totals, considering discounts and taxes.

1. In Visual Studio Code, navigate to the `sample/frontend/src/pages/order` folder. Open the `OrderCard.tsx` file for modification.
2. Here we are going to Create a OrderCard Ui component that will display the order details and amount.  
   Add some comments

   Note the inline suggestions and line completions suggested

3. - Open inline Co-pilot Prompt with (`Ctrl+I`), and enter the following prompt:
     In the inline chat, enter the following prompt:

   ```plaintext
   create a card component that displays order details and amount
   ```

4. Now lets create a Type Error and let copilot fix it for us.

   - Try to display a property that isnt on an Order

   - Observe the error in the editor and the suggested fix by Copilot.
   - Apply the fix and save the file.

## Copilot Edits

Using inline chat is very helpful in make quick updates on the go as you're working thru a user story or resolving a bug. However, you might've encountered some challenges with context especially when changes involve large code changes.

Navigate to the `sample/frontend/src/pages/CompanyPage.tsx` file and open it in the editor.

1. Open chat by clicking on the Copilot button at the bottom right hand side corner, this will open up a Copilot menu, select GitHub Copilot chat
2. Select the Copilot Edits button (see below) at the top left corner of the chat window:  
   ![copilot edit](./images/copilot-edits.png)
3. Click `+Add Files` and select Order.cs to add the `CompanyPage.tsx`, `types/company.tsx` and `types/order.tsx` files to the Copilot Edits.
4. Now have it attempt to generate the Company Page on its own

```plaintext
Create a Company Page that displays the company details and orders
```

You will notice that instead of generating code snippets like `Inline Chat`, copilot edits parses the entire Order class and modifies the logic accordingly.

## Summary

You have learned basics of several major features of GitHub Copilot, including:

- Autocomplete
- Inline Chat
- Copilot Chat
- Copilot Edits

**Next Steps:**

- [Lesson 3: Testing with GitHub Copilot](3-testing-with-copilot.md)
