//
//  ViewController.swift
//  LoveCal
//
//  Created by english on 2020-06-01.
//  Copyright © 2020 english. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    
    @IBOutlet weak var FirstName: UITextField!
    
    @IBOutlet weak var SecondName: UITextField!
    
    
    @IBOutlet weak var Result: UILabel!
    
    
    
    

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        
        Result.text = ""
        
    }

    
    
    @IBAction func Calculate_Button(_ sender: Any) {
        
        let love = CalculateLove()
        
        Result.text = "\(love)"
    
        
    }
    
    func CalculateLove()->Int{
       let number = Int.random(in: 0 ..< 100)
        
        return number;
    }

}

