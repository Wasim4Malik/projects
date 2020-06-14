//
//  ViewController.swift
//  Calculator
//
//  Created by english on 2020-06-01.
//  Copyright © 2020 english. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var value1: UITextField!
    
    @IBOutlet weak var value2: UITextField!
    
    @IBOutlet weak var result: UILabel!
    
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        
        result.text = ""
        
    }

    @IBAction func Divider(_ sender: Any) {
        
        let text1 = Double(value1.text!)
        let text2 = Double(value2.text!)
   
        let ans = Double (text1! / text2!)
        result.text = "\(ans)"
    
    }
    
    
    @IBAction func multi(_ sender: Any) {
        
        
        let text1 = Double(value1.text!)
             let text2 = Double(value2.text!)
        
             let ans = Double (text1! * text2!)
             result.text = "\(ans)"
         
    }
    
    
    @IBAction func substract(_ snder: Any) {
    
    let text1 = Double(value1.text!)
         let text2 = Double(value2.text!)
    
         let ans = Double (text1! - text2!)
         result.text = "\(ans)"
     
    
    
    }
    
    
    @IBAction func add(_ sender: Any) {
    
    let text1 = Double(value1.text!)
         let text2 = Double(value2.text!)
    
         let ans = Double (text1! + text2!)
         result.text = "\(ans)"
     
    
    }
    
    
    
    

}

