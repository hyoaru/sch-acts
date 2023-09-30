<?php 
    class Model_Record extends CI_Model {
        public $record_id;
        public $greeting;
        public $fname;
        public $lname;
        public $mi;
        public $subject_1;
        public $subject_2;
        public $subject_3;
        public $subject_4;
        public $response;
        public $comment;

        public function __construct() {
            parent::__construct();
        }

        public function save(){
            $this->load->database();
            
            $greeting = $this -> greeting;
            $fname = $this -> fname;
            $lname = $this -> lname;
            $mi = $this -> mi;
            $subject_1 = $this -> subject_1;
            $subject_2 = $this -> subject_2;
            $subject_3 = $this -> subject_3;
            $subject_4 = $this -> subject_4;
            $response = $this -> response;
            $comment = $this -> comment;
            
            $sql = "INSERT INTO `record` (greeting, fname, lname, mi, subject_1, subject_2, subject_3, subject_4, response, comment) values ('$greeting', '$fname', '$lname', '$mi', '$subject_1', '$subject_2', '$subject_3', '$subject_4', '$response', '$comment')";

            $this->db->query($sql);
        }

    }
?>