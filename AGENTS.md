## 项目背景

C#上位机学习项目，用户0基础 + 自动化售后调试背景，目标2027年3月入职成都。

## 数据来源

计划基于2025-2026年成都/深圳公开JD调研 + 四家AI（ChatGPT/Gemini/豆包）交叉验证。

## 路线

详见 `.planning/task_plan.md`，五阶段：
0. 环境与工具链（1周）✅ 已完成
1. C#进阶+多线程+文件IO（4周）🔄 进行中
2. SQL Server+Dapper+EF Core（5周）
3. 工业通信（TCP/SerialPort/Modbus/S7/OPC UA）（8周）
4. WPF+MVVM+项目实战（8周）

## 时间分配

- 在职学习，每晚 2 ~ 2.5 小时
- 每周 5+2 模式：5 天学知识做练习 + 2 天综合项目实战
- 每两周必须产出可运行的阶段性成果

## 技术栈

C#、WinForm、WPF、MVVM(CommunityToolkit)、SQL Server、MySQL(概念)、Dapper、EF Core、Socket、TCP/UDP、SerialPort、Modbus TCP/RTU、S7.Net、OPC UA(概念)、LiveCharts、HandyControl、Git、EPPlus/ClosedXML、NLog、SunnyUI、Wireshark

## 红线

- 禁止 CheckForIllegalCrossThreadCalls = false
- 禁止简历写SQLite
- 固定布局可拖控件节省时间，动态生成必须手写代码
- 禁止WPF深挖ControlTemplate/动画/毛玻璃
- 禁止WinForm原生控件自定义样式——用SunnyUI
- 计划基于真实数据，禁止臆测

## ⚠️ 教学方式（铁律，不可违反）

用户已经掌握的知识点，**只给场景+数据+方法名+提示**，绝不给完整代码行：

```
正确示范：
  场景：6台PLC温度数据
  数据：(粘贴数据)
  方法：Where、OrderByDescending、Select
  提示：
    - Where 条件你写过 n => n > 10，换变量和数字
    - OrderByDescending 跟 OrderBy 只差一个单词
    - Select 取 d.Name 字段

错误示范：
  devices.Where(d => d.Temp > 40).OrderByDescending(...)  ← 禁止直接给代码
```

**唯一例外**：新概念第一次出现时（如 delegate、LINQ、Socket），给完整示例 + 逐行拆解。


## ⚠️ 代码自检（铁律，不可违反）

每次为用户生成完整代码（补全方法、修复文件、生成新文件）后，**必须自己跑一遍检查**：

1. **编译检查**：用 `dotnet build` 或检查明显语法/引用错误
2. **中文检查**：所有中文字符串输出后必须用 `Select-String` 搜一遍，确认没有 `�` 乱码
3. **逻辑检查**：变量是否都存在、事件是否绑定正确、方法签名是否匹配
4. **发现错误立即修**，不要等用户来报错

```
正确流程：
  生成代码 → 写入文件 → 立即 build 验证 → 检查中文 → 确认无误后告诉用户

错误流程：
  生成代码 → 写入文件 → 直接告诉用户"写好了" → 用户F5报错 ← 绝不允许
```


## GitHub 推送

当用户说"推送到GitHub"、"push"、"上传到GitHub"、"同步到GitHub"时：
- 先 git add -A + git commit
- 然后提醒用户双击 `push.bat` 或在 PowerShell 执行 `cd E:\VS\WindowsFormsApp2; git push`
- Shell环境无法直连GitHub，推送需用户手动执行

## 学习节奏规则

### 项目/阶段完成提醒
- 每个小知识点完成 → 不需要提醒
- 每个项目做完（周末项目、阶段综合项目）→ 主动提醒："项目已完成，推送到GitHub？"
- 提醒时自动执行 git add -A + git commit，然后提醒用户运行 push.bat 或 git push

### 自动推进
- 按天规划，每天一个明确知识点/任务
- 完成当天任务后自动引导到下一天

### 不自动跳过
- 当天知识点没学完 → 不跳到下一天
- 同一知识点不反复纠缠，掌握即进下一步
- 小阶段结束主动询问掌握情况
- 用户说"还没好" → 不推进

### 练习机制
- 每天有小练手（10-15分钟）
- 每周有综合项目
- 项目来源：GitHub搜索优先 → 找不到自创

### 遇到问题
1. 独立思考改代码
2. GitHub搜索：https://github.com/dashboard
3. Microsoft官方文档
4. 再问我

## 规划文件

| 文件 | 用途 |
|------|------|
| .planning/task_plan.md | 五阶段+JD匹配+四家AI决策记录 |
| .planning/findings.md | 调研结论+AI交叉验证矩阵 |
| .planning/progress.md | 会话日志+错误记录+五问检查 |

## 当前进度

阶段一·W1D6-7 完成 → W2D1

- [x] W1D1-D4：委托/事件/Lambda/LINQ 全部完成 ✅
- [x] W1D5：LINQ链式调用——设备数据筛选排序 ✅
- [x] W1D6-7：周末项目-数据筛选小工具 ✅

## ⚠️ 代码生成前自检（铁律，不可违反）

每次为用户生成完整代码前，**必须自己先跑一遍**：

1. **编译检查**：写入文件后立即 `dotnet build --no-restore`，确认 0 错误
2. **中文检查**：`Select-String` 搜 `?` 确认无乱码
3. **逻辑检查**：变量存在？事件绑定正确？方法签名匹配？
4. **发现错误立即修**，不要把带 bug 的代码交给用户

```
正确流程：
  生成代码 → 写入文件 → 立即 build → 检查中文 → 确认无误后告诉用户

错误流程：
  生成代码 → 告诉用户"写好了" → 用户F5报错 ← 绝不允许
```
