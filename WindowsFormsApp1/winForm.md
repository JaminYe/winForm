###### Windows����

1. ����: 
   1. name:���������
   2. windowsState:��ʼ������Ĵ�С,Normal,Minimized,Maximized
   3. StartPosition:������ʼλ��,Manual(��Location���Ծ���),CenterScreen(������ʾ),WindowsDefaultLocation(WindowsĬ��λ��),WindowsDefaultBounds(WindowsĬ��λ��,�߽���Windows����),CenterParent(�ڸ����ھ���)
   4. Text: ����ı���,���û���
   5. MaximizeBox,MinimizeBox: �Ƿ��������С���İ�ť
   6. BackColor:������ɫ
   7. BackgroundImage: ����ͼƬ
   8. BackgroundImageLayout: ����ͼƬ�Ĳ���, None��������ʾ����Tile��ͼ���ظ���Ĭ��ֵ����Stretch�����죩��Center�����У���Zoom���������Ŵ󵽺��ʴ�С��
   9. Enabled:�����Ƿ����
   10. Font: ���ô���������
   11. ForeColor:���ô�����������ɫ
   12. Icon:���ô���ͼ��
2. �¼�
   1. load:��������¼�
   2. mouseClick:��굥���¼�
   3. mouseDoubleClick:���˫���¼�
   4. mouseMove:����ƶ��¼�
   5. keyDown:���̰����¼�
   6. keyUp:�����ͷ��¼�
   7. FormClosing:����ر�ʱ�¼�
   8. FormClosed:����رպ��¼�
3. ��Ϣ��(DialogResult  MessageBox.Show(��ʾ��,������,ѡ���ťMessageBoxButtons ,��ʾ��ͼ��MessageBoxIcon)  
   1. ѡ�ť:OK,OKCancel,AbortRetryIgnore(��ֹ,����,����),YesNoCancel,YesNo,RetryCancel(����,ȡ��)
      2.��ʾ��ͼ��:None,(Hand,Stop,Error)��x,Question�ʺ�,(Exclamation,Warning)����,(Asterisk,Information)��ʾ
      3.����ֵ:None,Ok,Cancel,Abort(��ֹ),Retry(����),Ignore(����),Yes,No
4. Label��LinkLabel����ǩ�ؼ�
   - Name: ��ǩ��,Ψһ��ʶ
   - Text:����
   - Font:������ʽ
   - FontColor:�ı���ɫ
   - BackColor:������ɫ
   - Image:����ͼƬ
   - AutoSize:�Ƿ��Զ�������ǩ��С true,false
   - Size:��ǩ��С
   - Visible:��ǩ�Ƿ�ɼ�
     5.TextBox���ı���
   - Text: �ı�����
   - MaxLength���ı�����������ַ�����
   - WordWrap���Զ�����
   - PasswordChar�������ַ��滻
   - Multiline�������ı��ı���
   - ReadOnly��ֻ��
   - Lines���ı�����
   - ScrollBars��������
5. Button����ť�ؼ�
6. RadioButton����ѡ��ť
7. CheckBox����ѡ��ť
8. CheckedListBox����ѡ����
9. ListBox���б�
   - MultiColumn���б��Ƿ�֧�ֶ���
   - Items���б���ֵ
   - SelectedItems��ѡ����ļ���
   - SelectedItem��ѡ����
   - SelectedIndex��ѡ���������
   - SelectionMode���б�ѡ��ģʽ
     - One:ֻ��ѡ��һ��
     - MultiSimple :��ѡ�����
     - None: ����ѡ��
     - MultiExtended:��ѡ����Ҫ����shift
   - ����:
     - Add: �����
     - Insert: ָ��λ�������
     - Remove: �Ƴ���
10. ComboBox:��Ͽ�
    - DropDownStyle:��� Simple(��ʾ�ı�����б��,�ı���ɱ༭),DropDown(ֻ��ʾ�ı���,�ı����ͨ�����չ��,�ɱ༭),DropDownList(ֻ��ʾ�ı���,�ı����ͨ�����չ��,���ɱ༭)
    - Items: ��ȡ����������е�ֵ
    - Text:��ȡ��������Ͽ��е��ı�
    - MaxDropDownItems: ��ȡ�����������ʾ������
    - Stored: �Ƿ�����
11. PictureBox:ͼƬ�ؼ�
    - Image:��ȡ��������ʾ��ͼƬ
    - ImageLocation: ��ȡ������ͼƬ·��
    - SizeMode: ����ͼƬ��ʾ��С��λ��Normal(��ʾ�����Ͻ�),Stretchimage(��Ӧ�ؼ���С),AutoSize(�ؼ���С��ӦͼƬ��С),Centerimage(ͼƬ��ͼƬ�ؼ�����),Zoom(ͼƬ�Զ�����������ͼƬ�ؼ��Ĵ�С)
12. Timer:��ʱ���ؼ�
13. ����ʱ��ؼ�
	- Short:�����ڸ�ʽ,����2019/1/1
	- Long:�����ڸ�ʽ,����2019��1��1��
	- Time:����ʾʱ��,����22:00:00
	- Custom:�û��Զ�����ʾ��ʽ
14. ContextMeanStrip :�һ��˵��ؼ�
15. MeauStrip: �˵����ؼ�
16. StatusStrip:״̬���ؼ�
17. progressBar:�������ؼ�
18. ToolStrip:�������ؼ�
19. MDI����:���ô���IsMdiContainer����Ϊtrue,�����´����MdiParentΪ��ǰ����
20. OpenFileDialog��SaveFileDialog���ļ��뱣���ļ�:ͨ�����������
21. RichTextBox���ı��༭��:loadFile�����ļ�,saveFile�����ļ�
22. NumericUpDown���������:DecimalPlaces:����С�����λ�� Increment ���Ӽ��ٵ���
23. ToolTip:������ʾ�ؼ�: 
	```c#
	private void ToolTip1_Popup_1(object sender,PopupEventArgs e) {
        ToolTip toolTip = (ToolTip)sender;
        if (e.AssociatedControl.Name == "textPass") {
        toolTip.ToolTipTitle = "��ʾ��Ϣ";
        toolTip.ToolTipIcon = ToolTipIcon.Info;
        } else {
        toolTip.ToolTipTitle = "������Ϣ";
        toolTip.ToolTipIcon = ToolTipIcon.Warning;
        }
        }
	```
24.notifyIcon���̿ؼ�
```c#
		/// <summary>
        /// ��������С��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeChange(object sender,EventArgs e) {
        if(WindowState == FormWindowState.Minimized) {
        this.Hide();
        notifyIcon1.Visible = true;
        notifyIcon1.ShowBalloonTip(20,"demo","this is a demo",ToolTipIcon.Warning);
        }
        }
        /// <summary>
        /// ˫������ͼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon1_MouseDoubleClick(object sender,MouseEventArgs e) {
        if(WindowState == FormWindowState.Minimized) {
        this.Show();
        this.WindowState = FormWindowState.Normal;
        }
        }

        /// <summary>
        /// �����һ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ����ҳ��ToolStripMenuItem_Click(object sender,EventArgs e) {
        this.Show();
        WindowState = FormWindowState.Normal;
        }
        /// <summary>
        /// �����һ��˳�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void �˳�ToolStripMenuItem_Click(object sender,EventArgs e) {
        this.Close();
        }
```
25. treeView1���ؼ�