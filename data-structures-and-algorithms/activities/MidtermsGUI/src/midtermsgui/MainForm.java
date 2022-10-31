package midtermsgui;

import java.util.Arrays;
import java.util.Random;

public class MainForm extends javax.swing.JFrame {
    private Random random = new Random();
    
    private int[] array1;
    private int[] array2;
    private int[] arrayMerged;
    
    private javax.swing.JTextField[] textFieldRepresentationArray1;
    private javax.swing.JTextField[] textFieldRepresentationArray2;
    private javax.swing.JTextField[] textFieldRepresentationArrayMerged;
    
    private javax.swing.JRadioButton[] arrayOption;
        
    public MainForm() {
        initComponents();
        
        textFieldRepresentationArray1 = new javax.swing.JTextField[] {
            txtBox1ArraySectionFirst, txtBox2ArraySectionFirst, 
            txtBox3ArraySectionFirst, txtBox4ArraySectionFirst
        };
        textFieldRepresentationArray2 = new javax.swing.JTextField[] {
            txtBox1ArraySectionSecond, txtBox2ArraySectionSecond, 
            txtBox3ArraySectionSecond, txtBox4ArraySectionSecond
        };
        textFieldRepresentationArrayMerged = new javax.swing.JTextField[] {
            txtBox1ArraySectionMerged, txtBox2ArraySectionMerged, 
            txtBox3ArraySectionMerged, txtBox4ArraySectionMerged,
            txtBox5ArraySectionMerged, txtBox6ArraySectionMerged, 
            txtBox7ArraySectionMerged, txtBox8ArraySectionMerged,
        };
        
        array1 = new int[textFieldRepresentationArray1.length];
        array2 = new int[textFieldRepresentationArray2.length];
        arrayMerged = new int[textFieldRepresentationArrayMerged.length];
        
        arrayOption = new javax.swing.JRadioButton[]{
            rdoArrayOptionsArray1, rdoArrayOptionsArray2,
            rdoArrayOptionsArrayMerged
        };
        
        arrayOption[0].setSelected(true);
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        btgArrayOptions = new javax.swing.ButtonGroup();
        pnlFormMain = new javax.swing.JPanel();
        pnlMainHeader = new javax.swing.JPanel();
        lblFormMain = new javax.swing.JLabel();
        pnlArraysCluster = new javax.swing.JPanel();
        pnlArraySectionMainFirst = new javax.swing.JPanel();
        lblArraySectionMainFirst = new javax.swing.JLabel();
        pnlArraySectionBodyFirst = new javax.swing.JPanel();
        txtBox1ArraySectionFirst = new javax.swing.JTextField();
        txtBox2ArraySectionFirst = new javax.swing.JTextField();
        txtBox3ArraySectionFirst = new javax.swing.JTextField();
        txtBox4ArraySectionFirst = new javax.swing.JTextField();
        btnGenerateArraySectionFirst = new javax.swing.JButton();
        pnlArraySectionMainSecond = new javax.swing.JPanel();
        lblArraySectionMainSecond = new javax.swing.JLabel();
        pnlArraySectionBodySecond = new javax.swing.JPanel();
        txtBox1ArraySectionSecond = new javax.swing.JTextField();
        txtBox2ArraySectionSecond = new javax.swing.JTextField();
        txtBox3ArraySectionSecond = new javax.swing.JTextField();
        txtBox4ArraySectionSecond = new javax.swing.JTextField();
        btnGenerateArraySectionSecond = new javax.swing.JButton();
        pnlArraySectionMainMerged = new javax.swing.JPanel();
        lblArraySectionMainMerged = new javax.swing.JLabel();
        pnlArraySectionBodyMerged = new javax.swing.JPanel();
        txtBox1ArraySectionMerged = new javax.swing.JTextField();
        txtBox2ArraySectionMerged = new javax.swing.JTextField();
        txtBox3ArraySectionMerged = new javax.swing.JTextField();
        txtBox4ArraySectionMerged = new javax.swing.JTextField();
        txtBox5ArraySectionMerged = new javax.swing.JTextField();
        txtBox6ArraySectionMerged = new javax.swing.JTextField();
        txtBox7ArraySectionMerged = new javax.swing.JTextField();
        txtBox8ArraySectionMerged = new javax.swing.JTextField();
        btnMergeArraySectionMerged = new javax.swing.JButton();
        pnlArrayOptions = new javax.swing.JPanel();
        lblArrayOptions = new javax.swing.JLabel();
        pnlArrayOptionsBtnGroup = new javax.swing.JPanel();
        rdoArrayOptionsArray1 = new javax.swing.JRadioButton();
        rdoArrayOptionsArray2 = new javax.swing.JRadioButton();
        rdoArrayOptionsArrayMerged = new javax.swing.JRadioButton();
        tpnOperations = new javax.swing.JTabbedPane();
        pnlOperationsFindAndReplace = new javax.swing.JPanel();
        pnlOperationsFindAndReplaceSectionInputOutput = new javax.swing.JPanel();
        lblOperationFind = new javax.swing.JLabel();
        spnOperationFind = new javax.swing.JSpinner();
        lblOperationReplace = new javax.swing.JLabel();
        spnOperationReplace = new javax.swing.JSpinner();
        lblOperationFoundAt = new javax.swing.JLabel();
        txtOperationFoundAt = new javax.swing.JTextField();
        pnlOperationsFindAndReplaceSectionOperations = new javax.swing.JPanel();
        cmbOperationOptions = new javax.swing.JComboBox<>();
        btnOperationExecute = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setAutoRequestFocus(false);

        pnlFormMain.setBackground(new java.awt.Color(255, 255, 255));

        pnlMainHeader.setBackground(new java.awt.Color(255, 255, 255));

        lblFormMain.setFont(new java.awt.Font("Segoe UI Black", 0, 24)); // NOI18N
        lblFormMain.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblFormMain.setText("Data Structure and Algorithms Midterms");

        javax.swing.GroupLayout pnlMainHeaderLayout = new javax.swing.GroupLayout(pnlMainHeader);
        pnlMainHeader.setLayout(pnlMainHeaderLayout);
        pnlMainHeaderLayout.setHorizontalGroup(
            pnlMainHeaderLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlMainHeaderLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblFormMain, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        pnlMainHeaderLayout.setVerticalGroup(
            pnlMainHeaderLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlMainHeaderLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblFormMain, javax.swing.GroupLayout.PREFERRED_SIZE, 31, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(12, Short.MAX_VALUE))
        );

        pnlArraysCluster.setBackground(new java.awt.Color(255, 255, 255));

        pnlArraySectionMainFirst.setBackground(new java.awt.Color(255, 255, 255));
        pnlArraySectionMainFirst.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(231, 231, 231), 1, true));

        lblArraySectionMainFirst.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        lblArraySectionMainFirst.setText("Array 1");
        lblArraySectionMainFirst.setAlignmentY(0.0F);

        pnlArraySectionBodyFirst.setBackground(new java.awt.Color(255, 255, 255));
        pnlArraySectionBodyFirst.setLayout(new java.awt.GridLayout(1, 0));

        txtBox1ArraySectionFirst.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox1ArraySectionFirst.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox1ArraySectionFirst.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodyFirst.add(txtBox1ArraySectionFirst);

        txtBox2ArraySectionFirst.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox2ArraySectionFirst.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox2ArraySectionFirst.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodyFirst.add(txtBox2ArraySectionFirst);

        txtBox3ArraySectionFirst.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox3ArraySectionFirst.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox3ArraySectionFirst.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodyFirst.add(txtBox3ArraySectionFirst);

        txtBox4ArraySectionFirst.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox4ArraySectionFirst.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        pnlArraySectionBodyFirst.add(txtBox4ArraySectionFirst);

        btnGenerateArraySectionFirst.setFont(new java.awt.Font("Segoe UI", 0, 10)); // NOI18N
        btnGenerateArraySectionFirst.setText("Generate");
        btnGenerateArraySectionFirst.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGenerateArraySectionFirstActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout pnlArraySectionMainFirstLayout = new javax.swing.GroupLayout(pnlArraySectionMainFirst);
        pnlArraySectionMainFirst.setLayout(pnlArraySectionMainFirstLayout);
        pnlArraySectionMainFirstLayout.setHorizontalGroup(
            pnlArraySectionMainFirstLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlArraySectionMainFirstLayout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addComponent(lblArraySectionMainFirst, javax.swing.GroupLayout.PREFERRED_SIZE, 68, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnlArraySectionBodyFirst, javax.swing.GroupLayout.PREFERRED_SIZE, 298, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(btnGenerateArraySectionFirst, javax.swing.GroupLayout.PREFERRED_SIZE, 76, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnlArraySectionMainFirstLayout.setVerticalGroup(
            pnlArraySectionMainFirstLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlArraySectionMainFirstLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlArraySectionMainFirstLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(btnGenerateArraySectionFirst, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(lblArraySectionMainFirst, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, pnlArraySectionMainFirstLayout.createSequentialGroup()
                        .addComponent(pnlArraySectionBodyFirst, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );

        pnlArraySectionMainSecond.setBackground(new java.awt.Color(255, 255, 255));
        pnlArraySectionMainSecond.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(231, 231, 231), 1, true));

        lblArraySectionMainSecond.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        lblArraySectionMainSecond.setText("Array 2");
        lblArraySectionMainSecond.setAlignmentY(0.0F);

        pnlArraySectionBodySecond.setBackground(new java.awt.Color(255, 255, 255));
        pnlArraySectionBodySecond.setLayout(new java.awt.GridLayout(1, 0));

        txtBox1ArraySectionSecond.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox1ArraySectionSecond.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox1ArraySectionSecond.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodySecond.add(txtBox1ArraySectionSecond);

        txtBox2ArraySectionSecond.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox2ArraySectionSecond.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox2ArraySectionSecond.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodySecond.add(txtBox2ArraySectionSecond);

        txtBox3ArraySectionSecond.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox3ArraySectionSecond.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox3ArraySectionSecond.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodySecond.add(txtBox3ArraySectionSecond);

        txtBox4ArraySectionSecond.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox4ArraySectionSecond.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox4ArraySectionSecond.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodySecond.add(txtBox4ArraySectionSecond);

        btnGenerateArraySectionSecond.setFont(new java.awt.Font("Segoe UI", 0, 10)); // NOI18N
        btnGenerateArraySectionSecond.setText("Generate");
        btnGenerateArraySectionSecond.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGenerateArraySectionSecondActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout pnlArraySectionMainSecondLayout = new javax.swing.GroupLayout(pnlArraySectionMainSecond);
        pnlArraySectionMainSecond.setLayout(pnlArraySectionMainSecondLayout);
        pnlArraySectionMainSecondLayout.setHorizontalGroup(
            pnlArraySectionMainSecondLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlArraySectionMainSecondLayout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addComponent(lblArraySectionMainSecond, javax.swing.GroupLayout.PREFERRED_SIZE, 68, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnlArraySectionBodySecond, javax.swing.GroupLayout.PREFERRED_SIZE, 298, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(btnGenerateArraySectionSecond, javax.swing.GroupLayout.PREFERRED_SIZE, 76, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnlArraySectionMainSecondLayout.setVerticalGroup(
            pnlArraySectionMainSecondLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlArraySectionMainSecondLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlArraySectionMainSecondLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(btnGenerateArraySectionSecond, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(lblArraySectionMainSecond, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, pnlArraySectionMainSecondLayout.createSequentialGroup()
                        .addComponent(pnlArraySectionBodySecond, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );

        pnlArraySectionMainMerged.setBackground(new java.awt.Color(255, 255, 255));
        pnlArraySectionMainMerged.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(231, 231, 231), 1, true));

        lblArraySectionMainMerged.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        lblArraySectionMainMerged.setText("Merged");
        lblArraySectionMainMerged.setAlignmentY(0.0F);

        pnlArraySectionBodyMerged.setBackground(new java.awt.Color(255, 255, 255));
        pnlArraySectionBodyMerged.setLayout(new java.awt.GridLayout(1, 0));

        txtBox1ArraySectionMerged.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox1ArraySectionMerged.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox1ArraySectionMerged.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodyMerged.add(txtBox1ArraySectionMerged);

        txtBox2ArraySectionMerged.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox2ArraySectionMerged.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox2ArraySectionMerged.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodyMerged.add(txtBox2ArraySectionMerged);

        txtBox3ArraySectionMerged.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox3ArraySectionMerged.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox3ArraySectionMerged.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodyMerged.add(txtBox3ArraySectionMerged);

        txtBox4ArraySectionMerged.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox4ArraySectionMerged.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox4ArraySectionMerged.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodyMerged.add(txtBox4ArraySectionMerged);

        txtBox5ArraySectionMerged.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox5ArraySectionMerged.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox5ArraySectionMerged.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodyMerged.add(txtBox5ArraySectionMerged);

        txtBox6ArraySectionMerged.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox6ArraySectionMerged.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox6ArraySectionMerged.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodyMerged.add(txtBox6ArraySectionMerged);

        txtBox7ArraySectionMerged.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox7ArraySectionMerged.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox7ArraySectionMerged.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodyMerged.add(txtBox7ArraySectionMerged);

        txtBox8ArraySectionMerged.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        txtBox8ArraySectionMerged.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtBox8ArraySectionMerged.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        pnlArraySectionBodyMerged.add(txtBox8ArraySectionMerged);

        btnMergeArraySectionMerged.setFont(new java.awt.Font("Segoe UI", 0, 10)); // NOI18N
        btnMergeArraySectionMerged.setText("Merge");
        btnMergeArraySectionMerged.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMergeArraySectionMergedActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout pnlArraySectionMainMergedLayout = new javax.swing.GroupLayout(pnlArraySectionMainMerged);
        pnlArraySectionMainMerged.setLayout(pnlArraySectionMainMergedLayout);
        pnlArraySectionMainMergedLayout.setHorizontalGroup(
            pnlArraySectionMainMergedLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlArraySectionMainMergedLayout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addComponent(lblArraySectionMainMerged, javax.swing.GroupLayout.PREFERRED_SIZE, 68, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnlArraySectionBodyMerged, javax.swing.GroupLayout.PREFERRED_SIZE, 298, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(btnMergeArraySectionMerged, javax.swing.GroupLayout.PREFERRED_SIZE, 76, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnlArraySectionMainMergedLayout.setVerticalGroup(
            pnlArraySectionMainMergedLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlArraySectionMainMergedLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlArraySectionMainMergedLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(btnMergeArraySectionMerged, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(lblArraySectionMainMerged, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, pnlArraySectionMainMergedLayout.createSequentialGroup()
                        .addComponent(pnlArraySectionBodyMerged, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );

        javax.swing.GroupLayout pnlArraysClusterLayout = new javax.swing.GroupLayout(pnlArraysCluster);
        pnlArraysCluster.setLayout(pnlArraysClusterLayout);
        pnlArraysClusterLayout.setHorizontalGroup(
            pnlArraysClusterLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlArraysClusterLayout.createSequentialGroup()
                .addGap(0, 0, Short.MAX_VALUE)
                .addGroup(pnlArraysClusterLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addComponent(pnlArraySectionMainSecond, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pnlArraySectionMainMerged, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pnlArraySectionMainFirst, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
        );
        pnlArraysClusterLayout.setVerticalGroup(
            pnlArraysClusterLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlArraysClusterLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(pnlArraySectionMainFirst, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnlArraySectionMainSecond, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnlArraySectionMainMerged, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pnlArrayOptions.setBackground(new java.awt.Color(255, 255, 255));

        lblArrayOptions.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        lblArrayOptions.setText("Array Options");
        lblArrayOptions.setAlignmentY(0.0F);

        pnlArrayOptionsBtnGroup.setBackground(new java.awt.Color(255, 255, 255));
        pnlArrayOptionsBtnGroup.setLayout(new java.awt.GridLayout(1, 0));

        btgArrayOptions.add(rdoArrayOptionsArray1);
        rdoArrayOptionsArray1.setFont(new java.awt.Font("Segoe UI", 0, 11)); // NOI18N
        rdoArrayOptionsArray1.setText("Array 1");
        pnlArrayOptionsBtnGroup.add(rdoArrayOptionsArray1);

        btgArrayOptions.add(rdoArrayOptionsArray2);
        rdoArrayOptionsArray2.setFont(new java.awt.Font("Segoe UI", 0, 11)); // NOI18N
        rdoArrayOptionsArray2.setText("Array 2");
        pnlArrayOptionsBtnGroup.add(rdoArrayOptionsArray2);

        btgArrayOptions.add(rdoArrayOptionsArrayMerged);
        rdoArrayOptionsArrayMerged.setFont(new java.awt.Font("Segoe UI", 0, 11)); // NOI18N
        rdoArrayOptionsArrayMerged.setText("Array Merged");
        pnlArrayOptionsBtnGroup.add(rdoArrayOptionsArrayMerged);

        javax.swing.GroupLayout pnlArrayOptionsLayout = new javax.swing.GroupLayout(pnlArrayOptions);
        pnlArrayOptions.setLayout(pnlArrayOptionsLayout);
        pnlArrayOptionsLayout.setHorizontalGroup(
            pnlArrayOptionsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlArrayOptionsLayout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addComponent(lblArrayOptions, javax.swing.GroupLayout.PREFERRED_SIZE, 99, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnlArrayOptionsBtnGroup, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        pnlArrayOptionsLayout.setVerticalGroup(
            pnlArrayOptionsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(lblArrayOptions, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlArrayOptionsLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(pnlArrayOptionsBtnGroup, javax.swing.GroupLayout.DEFAULT_SIZE, 26, Short.MAX_VALUE)
                .addContainerGap())
        );

        tpnOperations.setBackground(new java.awt.Color(255, 255, 255));
        tpnOperations.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N

        pnlOperationsFindAndReplace.setBackground(new java.awt.Color(255, 255, 255));

        pnlOperationsFindAndReplaceSectionInputOutput.setBackground(new java.awt.Color(255, 255, 255));

        lblOperationFind.setFont(new java.awt.Font("Segoe UI", 0, 11)); // NOI18N
        lblOperationFind.setText("Find");

        lblOperationReplace.setFont(new java.awt.Font("Segoe UI", 0, 11)); // NOI18N
        lblOperationReplace.setText("Replace with");

        lblOperationFoundAt.setFont(new java.awt.Font("Segoe UI", 0, 11)); // NOI18N
        lblOperationFoundAt.setText("Found at ");

        javax.swing.GroupLayout pnlOperationsFindAndReplaceSectionInputOutputLayout = new javax.swing.GroupLayout(pnlOperationsFindAndReplaceSectionInputOutput);
        pnlOperationsFindAndReplaceSectionInputOutput.setLayout(pnlOperationsFindAndReplaceSectionInputOutputLayout);
        pnlOperationsFindAndReplaceSectionInputOutputLayout.setHorizontalGroup(
            pnlOperationsFindAndReplaceSectionInputOutputLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlOperationsFindAndReplaceSectionInputOutputLayout.createSequentialGroup()
                .addGap(24, 24, 24)
                .addComponent(lblOperationFind, javax.swing.GroupLayout.DEFAULT_SIZE, 33, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(spnOperationFind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(27, 27, 27)
                .addComponent(lblOperationReplace, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(spnOperationReplace, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(24, 24, 24)
                .addComponent(lblOperationFoundAt, javax.swing.GroupLayout.PREFERRED_SIZE, 62, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtOperationFoundAt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(27, 27, 27))
        );
        pnlOperationsFindAndReplaceSectionInputOutputLayout.setVerticalGroup(
            pnlOperationsFindAndReplaceSectionInputOutputLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlOperationsFindAndReplaceSectionInputOutputLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlOperationsFindAndReplaceSectionInputOutputLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblOperationReplace, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(spnOperationFind, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(spnOperationReplace, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblOperationFoundAt, javax.swing.GroupLayout.DEFAULT_SIZE, 24, Short.MAX_VALUE)
                    .addComponent(lblOperationFind, javax.swing.GroupLayout.DEFAULT_SIZE, 24, Short.MAX_VALUE)
                    .addComponent(txtOperationFoundAt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap())
        );

        pnlOperationsFindAndReplaceSectionOperations.setBackground(new java.awt.Color(255, 255, 255));

        cmbOperationOptions.setFont(new java.awt.Font("Segoe UI", 0, 11)); // NOI18N
        cmbOperationOptions.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Find", "Replace" }));

        btnOperationExecute.setFont(new java.awt.Font("Segoe UI", 0, 11)); // NOI18N
        btnOperationExecute.setText("Execute");
        btnOperationExecute.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnOperationExecuteActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout pnlOperationsFindAndReplaceSectionOperationsLayout = new javax.swing.GroupLayout(pnlOperationsFindAndReplaceSectionOperations);
        pnlOperationsFindAndReplaceSectionOperations.setLayout(pnlOperationsFindAndReplaceSectionOperationsLayout);
        pnlOperationsFindAndReplaceSectionOperationsLayout.setHorizontalGroup(
            pnlOperationsFindAndReplaceSectionOperationsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlOperationsFindAndReplaceSectionOperationsLayout.createSequentialGroup()
                .addGap(120, 120, 120)
                .addComponent(cmbOperationOptions, javax.swing.GroupLayout.PREFERRED_SIZE, 114, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(btnOperationExecute, javax.swing.GroupLayout.PREFERRED_SIZE, 113, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );
        pnlOperationsFindAndReplaceSectionOperationsLayout.setVerticalGroup(
            pnlOperationsFindAndReplaceSectionOperationsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlOperationsFindAndReplaceSectionOperationsLayout.createSequentialGroup()
                .addGap(5, 5, 5)
                .addGroup(pnlOperationsFindAndReplaceSectionOperationsLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnOperationExecute, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(cmbOperationOptions))
                .addContainerGap())
        );

        javax.swing.GroupLayout pnlOperationsFindAndReplaceLayout = new javax.swing.GroupLayout(pnlOperationsFindAndReplace);
        pnlOperationsFindAndReplace.setLayout(pnlOperationsFindAndReplaceLayout);
        pnlOperationsFindAndReplaceLayout.setHorizontalGroup(
            pnlOperationsFindAndReplaceLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnlOperationsFindAndReplaceSectionInputOutput, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(pnlOperationsFindAndReplaceSectionOperations, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        pnlOperationsFindAndReplaceLayout.setVerticalGroup(
            pnlOperationsFindAndReplaceLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlOperationsFindAndReplaceLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(pnlOperationsFindAndReplaceSectionInputOutput, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnlOperationsFindAndReplaceSectionOperations, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(18, Short.MAX_VALUE))
        );

        tpnOperations.addTab("Find and Replace", pnlOperationsFindAndReplace);

        javax.swing.GroupLayout pnlFormMainLayout = new javax.swing.GroupLayout(pnlFormMain);
        pnlFormMain.setLayout(pnlFormMainLayout);
        pnlFormMainLayout.setHorizontalGroup(
            pnlFormMainLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnlMainHeader, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(pnlFormMainLayout.createSequentialGroup()
                .addGap(113, 113, 113)
                .addGroup(pnlFormMainLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pnlArrayOptions, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pnlArraysCluster, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(tpnOperations))
                .addContainerGap(112, Short.MAX_VALUE))
        );
        pnlFormMainLayout.setVerticalGroup(
            pnlFormMainLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlFormMainLayout.createSequentialGroup()
                .addGap(53, 53, 53)
                .addComponent(pnlMainHeader, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnlArraysCluster, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnlArrayOptions, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(tpnOperations, javax.swing.GroupLayout.PREFERRED_SIZE, 129, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(106, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnlFormMain, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnlFormMain, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    // Generating random numbers section and its related functions
    private void generateRandomNumbers(javax.swing.JTextField[] textFieldRepresentationArray, int[] array){
        int randomNumber;
        for (int i = 0; i < textFieldRepresentationArray.length; i++) {
            randomNumber = random.nextInt(100);
            textFieldRepresentationArray[i].setText(String.valueOf(randomNumber));
            array[i] = randomNumber;
        }
    }
    
    // Merging arrays section and its related functions
    private void mergeArrays(int[][] arrayOfArraysToMerge){
        int indexOfMergedArray = 0;
        int numbersOfArrayIterated = 0;
        while(numbersOfArrayIterated != arrayOfArraysToMerge.length){
            for (int[] array : arrayOfArraysToMerge) {
                for (int i = 0; i < array.length; i++) {
                    int numberFetchedFromTheArray = array[i];
                    arrayMerged[indexOfMergedArray] = numberFetchedFromTheArray;
                    textFieldRepresentationArrayMerged[indexOfMergedArray].setText(
                        String.valueOf(numberFetchedFromTheArray));
                    indexOfMergedArray++;
                }
                numbersOfArrayIterated++;
            }
        }
    }
    
    private boolean arrayIsEmpty(int[] array){
        for (int value : array){
            if (value != 0){
                return false;
            }
        }
        return true;
    }
    
    // Getting selected array section
    private String getSelectedArrayOption(){
        for (javax.swing.JRadioButton button: arrayOption){
            if (button.isSelected()){
                return button.getText();
            }
        }
        return null;
    }
    
    // Find and replace section and its related functions
    private int[] arrayParseToIntegerFromString(String[] arrayToParse){
        int[] arrayParsedToInteger = new int[arrayToParse.length];
        for (int i = 0; i < arrayToParse.length; i++){
            arrayParsedToInteger[i] = Integer.parseInt(arrayToParse[i]);
        }
        return arrayParsedToInteger;
    }
    
    private int[] getIndexesOfNumberToFind(int[] arrayToSearch){
        String foundAtIndexesStringified = "";
        int numberToFind = (int) spnOperationFind.getValue();
        
        for (int i = 0; i < arrayToSearch.length; i++){
            int fetchedNumberFromArray = arrayToSearch[i];
            if (fetchedNumberFromArray == numberToFind){
                foundAtIndexesStringified += String.format("%d ", i);
            }
        }
        
        int[] foundAtIndexes = arrayParseToIntegerFromString(foundAtIndexesStringified.split(" "));
        return foundAtIndexes;
    }
    
    private void replaceValuesByIndex(
        javax.swing.JTextField[] textFieldRepresentationArray, 
        int[] arrayToSearch, int[] indexArray){
            int numberToReplace = (int) spnOperationReplace.getValue();

            for (int indexToReplace : indexArray) {
                arrayToSearch[indexToReplace] = numberToReplace;
                textFieldRepresentationArray[indexToReplace].setText(String.valueOf(numberToReplace));
            }
        }
    
    private void operationFind(){
        String arrayToUse = getSelectedArrayOption();
        int[] indexesFoundAt;
        
        switch (arrayToUse) {
            case "Array 1":
                indexesFoundAt = getIndexesOfNumberToFind(array1);
                txtOperationFoundAt.setText(Arrays.toString(indexesFoundAt));
                break;
            case "Array 2":
                indexesFoundAt = getIndexesOfNumberToFind(array2);
                txtOperationFoundAt.setText(Arrays.toString(indexesFoundAt));
                break;
            case "Array Merged":
                indexesFoundAt = getIndexesOfNumberToFind(arrayMerged);
                txtOperationFoundAt.setText(Arrays.toString(indexesFoundAt));
                break;                
        }
    }
    
    private void operationReplace(){
        int[] indexesToReplaceValues;       
        String arrayToUse = getSelectedArrayOption();
        
        switch (arrayToUse) {
            case "Array 1":
                indexesToReplaceValues = getIndexesOfNumberToFind(array1);
                replaceValuesByIndex(
                        textFieldRepresentationArray1, array1, 
                        indexesToReplaceValues);
                break;
            case "Array 2":
                indexesToReplaceValues = getIndexesOfNumberToFind(array2);
                replaceValuesByIndex(
                        textFieldRepresentationArray2, array2, 
                        indexesToReplaceValues);
                break;
            case "Array Merged":
                indexesToReplaceValues = getIndexesOfNumberToFind(arrayMerged);
                replaceValuesByIndex(
                        textFieldRepresentationArrayMerged, arrayMerged, 
                        indexesToReplaceValues);
                break;                
        }        
    }
    
    private void btnGenerateArraySectionFirstActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGenerateArraySectionFirstActionPerformed
        generateRandomNumbers(textFieldRepresentationArray1, array1);
    }//GEN-LAST:event_btnGenerateArraySectionFirstActionPerformed

    private void btnGenerateArraySectionSecondActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGenerateArraySectionSecondActionPerformed
        generateRandomNumbers(textFieldRepresentationArray2, array2);
    }//GEN-LAST:event_btnGenerateArraySectionSecondActionPerformed

    private void btnMergeArraySectionMergedActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMergeArraySectionMergedActionPerformed
        int[][] arrayOfArraysToMerge = new int[][] {array1, array2};
        for (int[] array : arrayOfArraysToMerge){
            if (arrayIsEmpty(array)){
                generateRandomNumbers(textFieldRepresentationArray1, array1);
                generateRandomNumbers(textFieldRepresentationArray2, array2);
            }
        }
        mergeArrays(arrayOfArraysToMerge);
    }//GEN-LAST:event_btnMergeArraySectionMergedActionPerformed

    private void btnOperationExecuteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnOperationExecuteActionPerformed
        txtOperationFoundAt.setText("");
        String selectedOperation = cmbOperationOptions.getSelectedItem().toString();
        
        switch (selectedOperation) {
            case "Find":
                operationFind();
                break;
            case "Replace":
                operationReplace();
                break;
        }
    }//GEN-LAST:event_btnOperationExecuteActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.ButtonGroup btgArrayOptions;
    private javax.swing.JButton btnGenerateArraySectionFirst;
    private javax.swing.JButton btnGenerateArraySectionSecond;
    private javax.swing.JButton btnMergeArraySectionMerged;
    private javax.swing.JButton btnOperationExecute;
    private javax.swing.JComboBox<String> cmbOperationOptions;
    private javax.swing.JLabel lblArrayOptions;
    private javax.swing.JLabel lblArraySectionMainFirst;
    private javax.swing.JLabel lblArraySectionMainMerged;
    private javax.swing.JLabel lblArraySectionMainSecond;
    private javax.swing.JLabel lblFormMain;
    private javax.swing.JLabel lblOperationFind;
    private javax.swing.JLabel lblOperationFoundAt;
    private javax.swing.JLabel lblOperationReplace;
    private javax.swing.JPanel pnlArrayOptions;
    private javax.swing.JPanel pnlArrayOptionsBtnGroup;
    private javax.swing.JPanel pnlArraySectionBodyFirst;
    private javax.swing.JPanel pnlArraySectionBodyMerged;
    private javax.swing.JPanel pnlArraySectionBodySecond;
    private javax.swing.JPanel pnlArraySectionMainFirst;
    private javax.swing.JPanel pnlArraySectionMainMerged;
    private javax.swing.JPanel pnlArraySectionMainSecond;
    private javax.swing.JPanel pnlArraysCluster;
    private javax.swing.JPanel pnlFormMain;
    private javax.swing.JPanel pnlMainHeader;
    private javax.swing.JPanel pnlOperationsFindAndReplace;
    private javax.swing.JPanel pnlOperationsFindAndReplaceSectionInputOutput;
    private javax.swing.JPanel pnlOperationsFindAndReplaceSectionOperations;
    private javax.swing.JRadioButton rdoArrayOptionsArray1;
    private javax.swing.JRadioButton rdoArrayOptionsArray2;
    private javax.swing.JRadioButton rdoArrayOptionsArrayMerged;
    private javax.swing.JSpinner spnOperationFind;
    private javax.swing.JSpinner spnOperationReplace;
    private javax.swing.JTabbedPane tpnOperations;
    private javax.swing.JTextField txtBox1ArraySectionFirst;
    private javax.swing.JTextField txtBox1ArraySectionMerged;
    private javax.swing.JTextField txtBox1ArraySectionSecond;
    private javax.swing.JTextField txtBox2ArraySectionFirst;
    private javax.swing.JTextField txtBox2ArraySectionMerged;
    private javax.swing.JTextField txtBox2ArraySectionSecond;
    private javax.swing.JTextField txtBox3ArraySectionFirst;
    private javax.swing.JTextField txtBox3ArraySectionMerged;
    private javax.swing.JTextField txtBox3ArraySectionSecond;
    private javax.swing.JTextField txtBox4ArraySectionFirst;
    private javax.swing.JTextField txtBox4ArraySectionMerged;
    private javax.swing.JTextField txtBox4ArraySectionSecond;
    private javax.swing.JTextField txtBox5ArraySectionMerged;
    private javax.swing.JTextField txtBox6ArraySectionMerged;
    private javax.swing.JTextField txtBox7ArraySectionMerged;
    private javax.swing.JTextField txtBox8ArraySectionMerged;
    private javax.swing.JTextField txtOperationFoundAt;
    // End of variables declaration//GEN-END:variables
  }
