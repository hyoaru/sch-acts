<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Records extends CI_Controller {

	/**
	 * Index Page for this controller.
	 *
	 * Maps to the following URL
	 * 		http://example.com/index.php/welcome
	 *	- or -
	 * 		http://example.com/index.php/welcome/index
	 *	- or -
	 * Since this controller is set as the default controller in
	 * config/routes.php, it's displayed at http://example.com/
	 *
	 * So any other public methods not prefixed with an underscore will
	 * map to /index.php/welcome/<method_name>
	 * @see https://codeigniter.com/userguide3/general/urls.html
	 */
	public function index()
	{
		$this->load->view('records');
	}

    public function save(){
        $greeting = $_POST['greeting'];
        $fname = $_POST['fname'];
        $lname = $_POST['lname'];
        $mi = $_POST['mi'];
        $response = $_POST['response'];
        $comment = $_POST['comment'];

        if(isset($_POST['subject_1'])){
            $subject_1 = $_POST['subject_1'];
        }else{
            $subject_1 = "0";
        }
    
        if(isset($_POST['subject_2'])){
            $subject_2 = $_POST['subject_2'];
        }else{
            $subject_2 = "0";
        }
    
        if(isset($_POST['subject_3'])){
            $subject_3 = $_POST['subject_3'];
        }else{
            $subject_3 = "0";
        }
    
        if(isset($_POST['subject_4'])){
            $subject_4 = $_POST['subject_4'];
        }else{
            $subject_4 = "0";
        }

        $model_record = $this->load->model("model_record");
        $this->model_record->greeting = $greeting;
        $this->model_record->fname = $fname;
        $this->model_record->lname = $lname;
        $this->model_record->mi = $mi;
        $this->model_record->subject_1 = $subject_1;
        $this->model_record->subject_2 = $subject_2;
        $this->model_record->subject_2 = $subject_2;
        $this->model_record->subject_3 = $subject_3;
        $this->model_record->subject_4 = $subject_4;
        $this->model_record->response = $response;
        $this->model_record->comment = $comment;
        $this->model_record->save();
    }
}
