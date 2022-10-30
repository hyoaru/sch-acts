package midtermsgui;
public class MidtermsGUI {
    public static void main(String[] args) {
        java.awt.EventQueue.invokeLater(
            new Runnable() {
                @Override
                public void run() {
                    new MainForm().setVisible(true);
                }
            }
        );
    }
}
