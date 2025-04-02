## 🧪 AI Prompt: Generate SQL Change Review Document from SQL Statement

You are a senior database administrator and software engineer. Your task is to review a **SQL statement** (including any inline comments or metadata) and generate a **SQL Change Review Document** that summarizes and explains the proposed change.

---

### 📝 Instructions:

Given a **SQL input document**, output a **SQL Change Review Document** that includes the following:

1. **Title**  
   Format as `[ChangeType]_[BriefSummary]`  
   Example: `UPDATE_Update_PPO_Verbiage_Text`

2. **Author**  
   Extract from the comment block in the SQL if available (e.g., `Greg Abel`)

3. **Date**  
   Use the DEV date from the SQL header if available (e.g., `10/29/2024`)

4. **Environments Tested**  
   List environments that have been tested based on the SQL metadata (DEV, QA, UAT, PROD)

5. **Affected Tables**  
   List all tables impacted by the SQL (e.g., `schedulelink.ppoverbiage`)

6. **Description of Change**  
   Summarize what the SQL statement is doing (e.g., updating text in a column for a specific PPO code)

7. **Reason for Change**  
   Based on ticket number, comment header, or inferred context, explain why the change was made (e.g., updated client-facing text for accuracy or branding)

---

### 📥 SQL Input Example:

```sql
/*
|| Author: Greg Abel
|| File: -- 238013 Update PPO Verbiage
|| Current Ticket: 238013
||
|| Modification History:
|| Changes in:	DEV	- 10/29/2024
||		QA 	-
||		UAT	-
||		PROD	-
||
*/
UPDATE
  schedulelink.ppoverbiage
SET
  txt_verbiage = 'The network discount shown above is based on your contract with Fast360. For questions contact SBR@careworks.com or 866-535-0905 x17244'
WHERE int_ppocode = 147;
```
